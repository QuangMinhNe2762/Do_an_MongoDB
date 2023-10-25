using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachHangGUI.DTO
{
    internal class KhachHang
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string Ma_kh { get; set; }
        public string Ten_kh { get; set; }
        public string Dia_chi { get; set; }
        public string Sdt { get; set; }
        public string password { get; set; }
        public override String ToString()
        {
            return "KhachHang{" +
                    "_id=" + _id +
                    "Ma_kh='" + Ma_kh + '\'' +
                    ", Ten_kh='" + Ten_kh + '\'' +
                    ", Dia_chi='" + Dia_chi + '\'' +
                    ", Sdt='" + Sdt + '\'' +
                    '}';
        }
    }
}
