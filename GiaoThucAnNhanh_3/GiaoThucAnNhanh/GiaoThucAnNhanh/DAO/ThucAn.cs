using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using GiaoThucAnNhanh.DTO;
namespace GiaoThucAnNhanh.DAO
{
     class ThucAn :db
    {
        private const string CollectionName = "Mon_an";

        private IMongoCollection<BsonDocument> Collection(Boolean Bson)
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<BsonDocument> c = d.GetCollection<BsonDocument>(CollectionName);
            return c;
        }

        private IMongoCollection<DTO.ThucAn> Collection()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<DTO.ThucAn> c = d.GetCollection<DTO.ThucAn>(CollectionName);
            return c;
        }
        public Object find()
        {

            List<DTO.ThucAn> result = Collection().Find(new BsonDocument()).ToList();
            return result;
        }

        public List<DTO.ThucAn> GetAll()
        {
            IMongoCollection<DTO.ThucAn> collection = Collection();
            var filter = Builders<DTO.ThucAn>.Filter.Empty;

            List<DTO.ThucAn> thucAnList = collection.Find(filter).ToList();

            return thucAnList;
        }

        public string GetMaMonAnCuoi()
        {
            IMongoCollection<DTO.ThucAn> collection = Collection();
            var filter = Builders<DTO.ThucAn>.Filter.Empty;
            var sort = Builders<DTO.ThucAn>.Sort.Descending("_id");
            var document = collection.Find(filter).Sort(sort).Limit(1).FirstOrDefault();
            string maMACuoi = document.Ma_mon_an;
            string socuoi = (int.Parse(maMACuoi.Substring(maMACuoi.Length - 2)) + 1).ToString();
            string maMAMoi = "M0" + socuoi;
            return maMAMoi;
        }
        public void Insert(DTO.ThucAn thucAn)
        {
            IMongoCollection<DTO.ThucAn> collection = Collection();
            collection.InsertOne(thucAn);
        }
        public void Edit(DTO.ThucAn thucAn)
        {
            IMongoCollection<DTO.ThucAn> collection = Collection();
            var filter = Builders<DTO.ThucAn>.Filter.Eq("_id", thucAn._id);
            var update = Builders<DTO.ThucAn>.Update
                .Set(x => x.Ma_mon_an, thucAn.Ma_mon_an)
                .Set(x => x.Ten_mon_an, thucAn.Ten_mon_an)
                .Set(x => x.Gia, thucAn.Gia);

            collection.UpdateOne(filter, update);
        }

        public void DeleteByMaMonAn(string maMonAn)
        {
            IMongoCollection<DTO.ThucAn> collection = Collection();
            var filter = Builders<DTO.ThucAn>.Filter.Eq("Ma_mon_an", maMonAn);

            collection.DeleteOne(filter);
        }

        public List<DTO.ThucAn> TimMonAnTheoMa(string maMonAn)
        {
            List<DTO.ThucAn> monAnList = new List<DTO.ThucAn>();

            // Thực hiện truy vấn cơ sở dữ liệu để tìm món ăn theo mã

            // Ví dụ, sử dụng MongoDB.Driver để truy vấn MongoDB
            IMongoCollection<DTO.ThucAn> collection = Collection();
            var filter = Builders<DTO.ThucAn>.Filter.Eq("Ma_mon_an", maMonAn);
            var results = collection.Find(filter).ToList();

            monAnList = results;

            return monAnList;
        }
        public List<DTO.ThucAn> TimMonAnTheoTen(string tenMonAn)
        {
            List<DTO.ThucAn> monAnList = new List<DTO.ThucAn>();

            // Thực hiện truy vấn cơ sở dữ liệu để tìm món ăn theo tên

            // Ví dụ, sử dụng MongoDB.Driver để truy vấn MongoDB
            IMongoCollection<DTO.ThucAn> collection = Collection();
            var filter = Builders<DTO.ThucAn>.Filter.Eq("Ten_mon_an", tenMonAn);
            var results = collection.Find(filter).ToList();

            monAnList = results;

            return monAnList;
        }
        public List<DTO.ThucAn> TimMonAnTheoGia(int gia)
        {
            List<DTO.ThucAn> monAnList = new List<DTO.ThucAn>();

            // Thực hiện truy vấn cơ sở dữ liệu để tìm món ăn theo giá

            // Ví dụ, sử dụng MongoDB.Driver để truy vấn MongoDB
            IMongoCollection<DTO.ThucAn> collection = Collection();
            var filter = Builders<DTO.ThucAn>.Filter.Eq("Gia", gia);
            var results = collection.Find(filter).ToList();

            monAnList = results;

            return monAnList;
        }
    }
}
