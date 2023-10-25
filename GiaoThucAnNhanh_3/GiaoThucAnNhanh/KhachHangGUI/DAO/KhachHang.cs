using KhachHangGUI.DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhachHangGUI.GUI;
using System.Windows.Forms;
namespace KhachHangGUI.DAO
{
    internal class KhachHang:db
    {
        public TrangChu_GUI Mainform = new TrangChu_GUI();
        private static DTO.KhachHang KHDDN=new DTO.KhachHang();
        private const string CollectionName = "Khach_hang";

        internal static DTO.KhachHang KHDDN1 { get => KHDDN; set => KHDDN = value; }

        private IMongoCollection<DTO.KhachHang> Collection()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<DTO.KhachHang> c = d.GetCollection<DTO.KhachHang>(CollectionName);
            return c;
        }
        public bool ThemKH(DTO.KhachHang khachHang)
        {
            IMongoCollection<DTO.KhachHang> collection = Collection();
            try
            {
                collection.InsertOne(khachHang);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public string maKHLast()
        {
            IMongoCollection<DTO.KhachHang> collection = Collection();
            var filter = Builders<DTO.KhachHang>.Filter.Empty;
            var sort = Builders<DTO.KhachHang>.Sort.Descending("_id");
            var document = collection.Find(filter).Sort(sort).Limit(1).FirstOrDefault();
            string makhCuoi = document.Ma_kh;
            int socuoi = 0;
            if (int.Parse(makhCuoi[makhCuoi.Length-1].ToString()) == 0)
            {
                socuoi = int.Parse(makhCuoi[makhCuoi.Length-2].ToString())+1;
            }
            else
            {
                socuoi = int.Parse(makhCuoi[makhCuoi.Length - 1].ToString())+1;
            }
            string makhMoi = "kh0" + socuoi;
            return makhMoi;
        }
        public bool xacNhanKH(string sdt,string password)
        {
            IMongoCollection<DTO.KhachHang> collection = Collection();
            var filter = Builders<DTO.KhachHang>.Filter.Eq("Sdt", sdt);
            var document = collection.Find(filter).FirstOrDefault();
            if(document != null)
            {
                if(password.Equals(document.password))
                {
                    KHDDN1 = document;
                    return true;
                }
            }
            return false;
        }
        public bool chinhSuaTT(DTO.KhachHang kh)
        {
            IMongoCollection<DTO.KhachHang> collection = Collection();
            var filter = Builders<DTO.KhachHang>.Filter.Eq("Ma_kh",KHDDN1.Ma_kh);
            var update = Builders<DTO.KhachHang>.Update
                .Set(x => x.Ten_kh, kh.Ten_kh)
                .Set(x => x.Dia_chi, kh.Dia_chi)
                .Set(x => x.password,kh.password);
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
        public DTO.KhachHang getkh()
        {
            return KHDDN1;
        }
    }
}
