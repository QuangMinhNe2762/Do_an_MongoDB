using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using GiaoThucAnNhanh.DTO;
using System.Windows.Forms;
using GiaoThucAnNhanh.GUI;

namespace GiaoThucAnNhanh.DAO
{
    class KhachHang : db
    {
        private const string CollectionName = "Khach_hang";

        private IMongoCollection<BsonDocument> Collection(Boolean Bson)
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<BsonDocument> c = d.GetCollection<BsonDocument>(CollectionName);
            return c;
        }

        private IMongoCollection<DTO.KhachHang> Collection()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<DTO.KhachHang> c = d.GetCollection<DTO.KhachHang>(CollectionName);
            return c;
        }

        public Object find()
        {
            List<DTO.KhachHang> result = Collection().Find(new BsonDocument()).ToList();
            return result;
        }

        public List<DTO.KhachHang> GetAll()
        {
            IMongoCollection<DTO.KhachHang> collection = Collection();
            var filter = Builders<DTO.KhachHang>.Filter.Empty;

            List<DTO.KhachHang> khachHangList = collection.Find(filter).ToList();

            return khachHangList;
        }

        public void Insert(DTO.KhachHang khachHang)
        {
            IMongoCollection<DTO.KhachHang> collection = Collection();
            collection.InsertOne(khachHang);
        }

        public void Edit(DTO.KhachHang khachHang)
        {
            IMongoCollection<DTO.KhachHang> collection = Collection();
            var filter = Builders<DTO.KhachHang>.Filter.Eq("_id", khachHang._id);
            var update = Builders<DTO.KhachHang>.Update
                .Set(x => x.Ma_kh, khachHang.Ma_kh)
                .Set(x => x.Ten_kh, khachHang.Ten_kh)
                .Set(x => x.Dia_chi, khachHang.Dia_chi)
                .Set(x => x.Sdt, khachHang.Sdt)
                .Set(x => x.password, khachHang.password);

            var result = collection.UpdateOne(filter, update);

            if (result.ModifiedCount == 0)
            {
                MessageBox.Show("Không tìm thấy bản ghi để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void DeleteByMaKhachHang(string maKhachHang)
        {
            IMongoCollection<DTO.KhachHang> collection = Collection();
            var filter = Builders<DTO.KhachHang>.Filter.Eq("Ma_kh", maKhachHang);

            collection.DeleteOne(filter);
        }

        public List<DTO.KhachHang> Find(string maKhachHang, string tenKhachHang, string diaChi, string sdt)
        {
            var collection = Collection();
            var filterBuilder = Builders<DTO.KhachHang>.Filter;
            var filter = filterBuilder.Empty;

            if (!string.IsNullOrEmpty(maKhachHang))
            {
                filter &= filterBuilder.Eq("Ma_kh", maKhachHang);
            }

            if (!string.IsNullOrEmpty(tenKhachHang))
            {
                filter &= filterBuilder.Eq("Ten_kh", tenKhachHang);
            }

            if (!string.IsNullOrEmpty(diaChi))
            {
                filter &= filterBuilder.Eq("Dia_chi", diaChi);
            }

            if (!string.IsNullOrEmpty(sdt))
            {
                filter &= filterBuilder.Eq("Sdt", sdt);
            }
            var khachHangList = collection.Find(filter).ToList();

            return khachHangList;
        }
    }
}
