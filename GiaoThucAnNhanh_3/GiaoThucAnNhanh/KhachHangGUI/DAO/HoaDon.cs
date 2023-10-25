using MongoDB.Bson;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachHangGUI.DAO
{
    internal class HoaDon : db
    {
        private const string CollectionName = "Hoa_don";
        private static DTO.HoaDon hoadonDangDat = new DTO.HoaDon();
        private IMongoCollection<DTO.HoaDon> Collection()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase database = mongo.GetDatabase(Database);
            IMongoCollection<DTO.HoaDon> collection = database.GetCollection<DTO.HoaDon>(CollectionName);
            return collection;
        }
        private static List<DTO.HoaDon_ThucAn> dsmonandadat = new List<DTO.HoaDon_ThucAn>();
        public void setDSMonAnDaDat(List<DTO.HoaDon_ThucAn> list)
        {
            dsmonandadat = list;
        }
        public List<DTO.HoaDon_ThucAn> getDSMonAnDaDat()
        {
            return dsmonandadat;
        }
        public int getTongTienDaDat()
        {
            int sum = 0;
            foreach (var item in dsmonandadat)
            {
                sum += item.thanh_tien;
            }
            return sum;
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
        public void ThemTTHDConLai()
        {
            hoadonDangDat.Ma_hd = GetMaHoaDonCuoi();
            hoadonDangDat.Ma_kh = db.KhachHang.getkh().Ma_kh;
            hoadonDangDat.Tong_tien = getTongTienDaDat();
            hoadonDangDat.Ds_mon_an = dsmonandadat;
            hoadonDangDat.Trang_thai="Chưa thanh toán";
        }
        public bool ThemHD()
        {
            ThemTTHDConLai();
            IMongoCollection<DTO.HoaDon> collection = Collection();
            try
            {
                collection.InsertOne(hoadonDangDat);
            }
            catch
            {
                return false;
            }
            hoadonDangDat = new DTO.HoaDon();
            return true;
        }
        // lấy tất cả hóa đơn của khách hàng đang đăng nhập
        public List<DTO.HoaDon> GetHoaDonList()
        {
            string trang_thai = "Chưa thanh toán";
            IMongoCollection<DTO.HoaDon> collection = Collection();
            var filter = Builders<DTO.HoaDon>.Filter.And(
                Builders<DTO.HoaDon>.Filter.Eq(x => x.Ma_kh, db.KhachHang.getkh().Ma_kh),
                Builders<DTO.HoaDon>.Filter.Eq(x => x.Trang_thai,trang_thai ));
            var projection = Builders<DTO.HoaDon>.Projection
                .Include("Ma_hd")
                .Include("Ma_kh")
                .Include("Tong_tien")
                .Include("Ds_mon_an")
                .Include("Trang_thai");
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
        private static DTO.HoaDon maHoaDon_TongTien = new DTO.HoaDon();
        public void setMaHoaDon(string n)
        {
            maHoaDon_TongTien.Ma_hd = n;
        }
        public string getMaHoaDon()
        {
            return maHoaDon_TongTien.Ma_hd;
        }
        public string getTongTien()
        {
            return maHoaDon_TongTien.Tong_tien.ToString();
        }
        public void setTongTien(int n)
        {
            maHoaDon_TongTien.Tong_tien = n;
        }
        public List<DTO.HoaDon_ThucAn> getDSMonAnTheoMakh()
        {
            List<DTO.HoaDon> hoaDonList = db.HoaDon.GetHoaDonList();
            var result_hd = hoaDonList.Where(x => x.Ma_hd.Equals(maHoaDon_TongTien.Ma_hd)).ToList();
            var ds_monan = result_hd[0].Ds_mon_an.ToList();
            GetTongTienHD();
            return ds_monan;
        }
        // trả về tổng tiền khi click vào hóa đơn ở trong bảng hóa đơn của khách hàng form khachhangGUI
        public void GetTongTienHD()
        {
            List<DTO.HoaDon> hoaDonList = db.HoaDon.GetHoaDonList();
            var result_hd = hoaDonList.FirstOrDefault(x => x.Ma_hd.Equals(maHoaDon_TongTien.Ma_hd));
            setTongTien(result_hd.Tong_tien);
        }
        // thay đổi trạng thái thanh toán hóa đơn
        public bool DaThanhToan()
        {
            IMongoCollection<DTO.HoaDon> collection = Collection();
            List<DTO.HoaDon> hoaDonList = db.HoaDon.GetHoaDonList();
            var filter = Builders<DTO.HoaDon>.Filter.Eq(x => x.Ma_hd, maHoaDon_TongTien.Ma_hd);
            var update = Builders<DTO.HoaDon>.Update.Set(x => x.Trang_thai, "Đã thanh toán");
            try
            {
                collection.UpdateOne(filter, update);
            }
            catch
            {
                return false;
            }
            maHoaDon_TongTien=new DTO.HoaDon();
            return true;
        }
    }
}
