using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace KhachHangGUI.DTO
{
    class HoaDon
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public String Ma_hd { get; set; }
        public int Tong_tien { get; set; }
        public List<HoaDon_ThucAn> Ds_mon_an { get; set; }
        public String Ma_kh { get; set; }
        public string Trang_thai{get; set; }
    }
}
