using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace GiaoThucAnNhanh.DTO
{
    class HoaDon_ThucAn
    {
        public string Tenmon { get; set; }
        public int Sl { get; set; }
        public int Gia { get; set; }
        public int thanh_tien { get; set; }
    }
}
