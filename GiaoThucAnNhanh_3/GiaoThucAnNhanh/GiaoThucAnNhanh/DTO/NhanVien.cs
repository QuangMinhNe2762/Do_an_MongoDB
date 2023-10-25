using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoThucAnNhanh.DTO
{
    class NhanVien
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public String Manv { get; set; }
        public String Hoten{ get; set; }
        public String Phai { get; set; }
        public int Luong { get; set; }
        public String Ngay_sinh {  get; set; }
        public String Sdt { get; set; }
    }
}
