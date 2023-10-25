using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using GiaoThucAnNhanh.DTO;
namespace GiaoThucAnNhanh.DAO
{
    class HoaDon:db
    {
        private const string CollectionName = "Hoa_don";
        private IMongoCollection<BsonDocument> Collection(bool useBson)
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase database = mongo.GetDatabase(Database);
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(CollectionName);
            return collection;
        }

        private IMongoCollection<DTO.HoaDon> Collection()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase database = mongo.GetDatabase(Database);
            IMongoCollection<DTO.HoaDon> collection = database.GetCollection<DTO.HoaDon>(CollectionName);
            return collection;
        }


        public List<DTO.HoaDon> GetHoaDonList()
        {
            IMongoCollection<DTO.HoaDon> collection = Collection();
            var filter = Builders<DTO.HoaDon>.Filter.Empty;
            var projection = Builders<DTO.HoaDon>.Projection
                .Include("Ma_hd")
                .Include("Ma_kh")
                .Include("Tong_tien")
                .Include("Ds_mon_an"); 
            var bsonDocuments = collection.Find(filter).Project<BsonDocument>(projection).ToList();

            var hoaDonList = new List<DTO.HoaDon>();
            foreach (var bsonDocument in bsonDocuments)
            {
                var hoaDon = new DTO.HoaDon
                {
                    Ma_hd = bsonDocument["Ma_hd"].AsString,
                    Ma_kh = bsonDocument["Ma_kh"].AsString,
                    Tong_tien = int.Parse(bsonDocument["Tong_tien"].ToString()),
                    Ds_mon_an = new List<DTO.HoaDon_ThucAn>()
                };

                if (bsonDocument["Ds_mon_an"].BsonType == BsonType.Array)
                {
                    var monAnArray = bsonDocument["Ds_mon_an"].AsBsonArray;
                    foreach (var monAnDoc in monAnArray)
                    {
                        var hoaDonThucAn = new DTO.HoaDon_ThucAn
                        {
                            Tenmon = monAnDoc["Tenmon"].AsString,
                            Sl = int.Parse(monAnDoc["Sl"].ToString()),
                            Gia = int.Parse(monAnDoc["Gia"].ToString()),
                            thanh_tien=int.Parse(monAnDoc["thanh_tien"].ToString())
                        };
                        hoaDon.Ds_mon_an.Add(hoaDonThucAn);
                    }
                }
                else if (bsonDocument["Ds_mon_an"].BsonType == BsonType.Document)
                {
                    var monAnDoc = bsonDocument["Ds_mon_an"].AsBsonDocument;
                    var hoaDonThucAn = new DTO.HoaDon_ThucAn
                    {
                        Tenmon = monAnDoc["Tenmon"].AsString,
                        Sl = int.Parse(monAnDoc["Sl"].ToString()),
                        Gia = int.Parse(monAnDoc["Gia"].ToString()),
                        thanh_tien = int.Parse(monAnDoc["thanh_tien"].ToString()),
                    };
                    hoaDon.Ds_mon_an.Add(hoaDonThucAn);
                }

                hoaDonList.Add(hoaDon);
            }

            return hoaDonList;
        }
        public void Insert(DTO.HoaDon hoaDon)
        {
            IMongoCollection<DTO.HoaDon> collection = Collection(); 
            collection.InsertOne(hoaDon);
        }
        public void DeleteByMaHoaDon(string maHoaDon)
        {
            IMongoCollection<DTO.HoaDon> collection = Collection();
            var filter = Builders<DTO.HoaDon>.Filter.Eq(x => x.Ma_hd, maHoaDon);

            collection.DeleteOne(filter);
        }


        
        public void AddMonAnToHoaDon(string maHoaDon, DTO.HoaDon_ThucAn monAn)
        {
            IMongoCollection<DTO.HoaDon> collection = Collection();
            List<DTO.ThucAn> listMA = db.ThucAn.GetAll();
            var tim_gia_mon_an = listMA.FirstOrDefault(x => x.Ten_mon_an == monAn.Tenmon);
            monAn.Gia = tim_gia_mon_an.Gia;
            monAn.thanh_tien = monAn.Gia * monAn.Sl;
            var filter = Builders<DTO.HoaDon>.Filter.Eq(x => x.Ma_hd, maHoaDon);
            var update = Builders<DTO.HoaDon>.Update.Push(x => x.Ds_mon_an, monAn);
            collection.UpdateOne(filter, update);
        }




        public void UpdateTongTien(string maHoaDon)
        {
            IMongoCollection<DTO.HoaDon> collection = Collection();
            var filter = Builders<DTO.HoaDon>.Filter.Eq(x => x.Ma_hd, maHoaDon);
            var hoaDon = collection.Find(filter).FirstOrDefault();
            if (hoaDon != null)
            {
                double tongTien = hoaDon.Ds_mon_an.Sum(x => x.Gia * x.Sl);
                var update = Builders<DTO.HoaDon>.Update.Set(x => x.Tong_tien, tongTien);

                collection.UpdateOne(filter, update);
            }
        }
        #region
        //public void UpdateMonAnInHoaDon(string maHoaDon, string tenMonAn, int soLuong,int gia,int thanh_tien)
        //{
        //    IMongoCollection<DTO.HoaDon> collection = Collection();
        //    var filter = Builders<DTO.HoaDon>.Filter.And(
        //        Builders<DTO.HoaDon>.Filter.Eq(x => x.Ma_hd, maHoaDon),
        //        Builders<DTO.HoaDon>.Filter.ElemMatch(x => x.Ds_mon_an, x => x.Tenmon == tenMonAn)
        //    );
        //    var update = Builders<DTO.HoaDon>.Update.Set(x => x.Ds_mon_an[0].Sl, soLuong)
        //                                            .Set(x => x.Ds_mon_an[0].Gia, gia)
        //                                            .Set(x => x.Ds_mon_an[0].thanh_tien,thanh_tien);
        //    collection.UpdateOne(filter, update);
        //}
        #endregion
        public void UpdateMonAnInHoaDon(string ma_hd,DTO.HoaDon_ThucAn monAn,int index,string tenMonCu)
        {
            IMongoCollection<DTO.HoaDon> collection = Collection();
            var filter = Builders<DTO.HoaDon>.Filter.And(
                Builders<DTO.HoaDon>.Filter.Eq(x => x.Ma_hd,ma_hd),
                Builders<DTO.HoaDon>.Filter.ElemMatch(x => x.Ds_mon_an, x => x.Tenmon == tenMonCu));

            var update = Builders<DTO.HoaDon>.Update.Set(x => x.Ds_mon_an[index].Sl, monAn.Sl)
                                                    .Set(x => x.Ds_mon_an[index].Tenmon, monAn.Tenmon)
                                                    .Set(x => x.Ds_mon_an[index].Gia, monAn.Gia)
                                                    .Set(x => x.Ds_mon_an[index].thanh_tien, monAn.thanh_tien);
            collection.UpdateOne(filter, update);
        }



        public void DeleteByMaHoaDonAndTenMonAn(string maHoaDon, string tenMonAn)
        {
            IMongoCollection<DTO.HoaDon> collection = Collection();
            var filter = Builders<DTO.HoaDon>.Filter.And(
                Builders<DTO.HoaDon>.Filter.Eq(x=>x.Ma_hd,maHoaDon),
                Builders<DTO.HoaDon>.Filter.ElemMatch(x=>x.Ds_mon_an,x=>x.Tenmon==tenMonAn)
                );
            var update = Builders<DTO.HoaDon>.Update.PullFilter("Ds_mon_an", Builders<DTO.HoaDon_ThucAn>.Filter.Eq("Tenmon", tenMonAn));
            collection.UpdateOne(filter, update);
            UpdateTongTien(maHoaDon);
        }
        public List<DTO.HoaDon_ThucAn> DsMonAnTheoMHD(string maHoaDon)
        {
            List<DTO.HoaDon> hoaDonList = db.HoaDon.GetHoaDonList();
            var result_hd = hoaDonList.Where(x => x.Ma_hd.Equals(maHoaDon)).ToList();
            var ds_monan = result_hd[0].Ds_mon_an.ToList();
            return ds_monan;
        }
        private IMongoCollection<DTO.ThucAn> CollectionThucAn()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<DTO.ThucAn> c = d.GetCollection<DTO.ThucAn>(CollectionName);
            return c;
        }
        public List<DTO.HoaDon> findValues(string searchString)
        {
            if (searchString.Length == 0)
            {
                return GetHoaDonList();
            }
            IMongoCollection<DTO.HoaDon> collection = Collection();
            var fields = new List<string> { "Ma_hd", "Ma_kh"};
            var searchConditions = new List<FilterDefinition<DTO.HoaDon>>();
            foreach (var field in fields)
            {
                var regexFilter = Builders<DTO.HoaDon>.Filter.Regex(field, new BsonRegularExpression(searchString, "i"));
                searchConditions.Add(regexFilter);
            }
            var searchFilter = Builders<DTO.HoaDon>.Filter.Or(searchConditions);
            var result = collection.Find(searchFilter).ToList();
            return result;
        }
        public DTO.HoaDon findTong_tienHD(string mahoadon)
        {
            IMongoCollection<DTO.HoaDon> collection = Collection();
            List<DTO.HoaDon> hoaDonList = db.HoaDon.GetHoaDonList();
            var result = hoaDonList.FirstOrDefault(x => x.Ma_hd == mahoadon);
            return result;
        }
        private static DTO.HoaDon tempMHD = new DTO.HoaDon();
        //4
        public bool ThemHoaDon()
        {
            if (tempMHD.Ma_kh != null)
            {
                try
                {
                    ThemDsMonAn();
                }
                catch
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        //2
        public void ThemTTConLai(DTO.HoaDon TTCL)
        {
            tempMHD = TTCL;
            tempMHD.Trang_thai = "Chưa thanh toán";
            tempMHD.Tong_tien = tempMHD.Ds_mon_an.Sum(x => x.thanh_tien);
        }
        //3
        public void ThemDsMonAn()
        {
            IMongoCollection<DTO.HoaDon> collection = Collection();
            collection.InsertOne(tempMHD);
        }
        // chạy hàm theo thứ tự 1
        public void ThemMaHoaDon(string maHoaDon)
        {
            tempMHD.Ma_hd = maHoaDon;
        }
        public int SumTienDaTT()
        {
            
            List<DTO.HoaDon> list =db.HoaDon.GetHoaDonList();
            int sum = 0;
            foreach (var item in list)
            {
                sum += item.Tong_tien;
            }
            return sum;
        }
        public List<DTO.HoaDon> Trang_thai_HD(string trangThai)
        {
            IMongoCollection<DTO.HoaDon> collection = Collection();
            var filter = Builders<DTO.HoaDon>.Filter.Eq(x=>x.Trang_thai,trangThai);
            var projection = Builders<DTO.HoaDon>.Projection
                .Include("Ma_hd")
                .Include("Ma_kh")
                .Include("Tong_tien")
                .Include("Ds_mon_an");
            var bsonDocuments = collection.Find(filter).Project<BsonDocument>(projection).ToList();

            var hoaDonList = new List<DTO.HoaDon>();
            foreach (var bsonDocument in bsonDocuments)
            {
                var hoaDon = new DTO.HoaDon
                {
                    Ma_hd = bsonDocument["Ma_hd"].AsString,
                    Ma_kh = bsonDocument["Ma_kh"].AsString,
                    Tong_tien = int.Parse(bsonDocument["Tong_tien"].ToString()),
                    Ds_mon_an = new List<DTO.HoaDon_ThucAn>()
                };

                if (bsonDocument["Ds_mon_an"].BsonType == BsonType.Array)
                {
                    var monAnArray = bsonDocument["Ds_mon_an"].AsBsonArray;
                    foreach (var monAnDoc in monAnArray)
                    {
                        var hoaDonThucAn = new DTO.HoaDon_ThucAn
                        {
                            Tenmon = monAnDoc["Tenmon"].AsString,
                            Sl = int.Parse(monAnDoc["Sl"].ToString()),
                            Gia = int.Parse(monAnDoc["Gia"].ToString()),
                            thanh_tien = int.Parse(monAnDoc["thanh_tien"].ToString())
                        };
                        hoaDon.Ds_mon_an.Add(hoaDonThucAn);
                    }
                }
                else if (bsonDocument["Ds_mon_an"].BsonType == BsonType.Document)
                {
                    var monAnDoc = bsonDocument["Ds_mon_an"].AsBsonDocument;
                    var hoaDonThucAn = new DTO.HoaDon_ThucAn
                    {
                        Tenmon = monAnDoc["Tenmon"].AsString,
                        Sl = int.Parse(monAnDoc["Sl"].ToString()),
                        Gia = int.Parse(monAnDoc["Gia"].ToString()),
                        thanh_tien = int.Parse(monAnDoc["thanh_tien"].ToString()),
                    };
                    hoaDon.Ds_mon_an.Add(hoaDonThucAn);
                }

                hoaDonList.Add(hoaDon);
            }

            return hoaDonList;
        }
        public string GetMaHoaDonCuoi()
        {
            IMongoCollection<DTO.HoaDon> collection = Collection();
            var filter = Builders<DTO.HoaDon>.Filter.Empty;
            var sort = Builders<DTO.HoaDon>.Sort.Descending("_id");
            var document = collection.Find(filter).Sort(sort).Limit(1).FirstOrDefault();
            string mahdCuoi = document.Ma_hd;
            string socuoi = (int.Parse(mahdCuoi.Substring(mahdCuoi.Length - 2)) + 1).ToString();
            string mahdMoi = "hd0" + socuoi;
            return mahdMoi;
        }
    }
}

