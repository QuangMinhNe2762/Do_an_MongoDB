using GiaoThucAnNhanh.DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using SharpCompress.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GiaoThucAnNhanh.DAO
{
    internal class NhanVien:db
    {
        private const string CollectionName = "Nhan_vien";
        private IMongoCollection<DTO.NhanVien> Collection()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<DTO.NhanVien> c = d.GetCollection<DTO.NhanVien>(CollectionName);
            return c;
        }
        // ds nhân viên
        public List<DTO.NhanVien> find()
        {
            List<DTO.NhanVien> result = Collection().Find(new BsonDocument()).ToList();
            return result;
        }
        //thêm nhân viên
        public bool Insert(DTO.NhanVien nhanvien) {
            IMongoCollection<DTO.NhanVien> collection=Collection();
            try
            {
                collection.InsertOne(nhanvien);
            }
            catch
            {
                return false;
            }
            return true;
        }
        //cập nhật thông tin nv
        public bool Update(DTO.NhanVien nhanvien)
        {
            IMongoCollection<DTO.NhanVien> collection = Collection();
            var filter = Builders<DTO.NhanVien>.Filter.Eq("Manv", nhanvien.Manv);
            var update = Builders<DTO.NhanVien>.Update.Set(x => x.Hoten, nhanvien.Hoten).Set(x => x.Ngay_sinh, nhanvien.Ngay_sinh).Set(x => x.Phai, nhanvien.Phai)
                .Set(x => x.Luong, nhanvien.Luong).Set(x => x.Sdt, nhanvien.Sdt);
            try
            {
                collection.UpdateOne(filter, update);
            }
            catch
            {
                return false;
            }
            return true;
        }
        //xóa nhân viên
        public bool Delete(string manv)
        {
            IMongoCollection<DTO.NhanVien> collection = Collection();
            var filter = Builders<DTO.NhanVien>.Filter.Eq("Manv", manv);
            try
            {
                collection.DeleteOne(filter);
            }
            catch
            {
                return false;
            }
            return true;
        }
        //tìm nhân viên theo mã,họ tên,phái,ngày sinh,số điện thoại
        public List<DTO.NhanVien> findValues(string searchString)
        {
            if(searchString.Length==0)
            {
                return find();
            }    
            IMongoCollection<DTO.NhanVien> collection = Collection();
            var fields = new List<string> { "Manv", "Hoten", "Phai","Ngay_sinh","Sdt"};
            var searchConditions = new List<FilterDefinition<DTO.NhanVien>>();
            foreach (var field in fields)
            {
                var regexFilter = Builders<DTO.NhanVien>.Filter.Regex(field, new BsonRegularExpression(searchString, "i"));
                searchConditions.Add(regexFilter);
            }
            var searchFilter = Builders<DTO.NhanVien>.Filter.Or(searchConditions);
            var result = collection.Find(searchFilter).ToList();
            return result;
        }
    }
}
