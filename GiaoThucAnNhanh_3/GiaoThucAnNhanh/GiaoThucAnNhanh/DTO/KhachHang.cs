using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GiaoThucAnNhanh.DTO
{
    class KhachHang
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
