using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KhachHangGUI.DTO
{
     class ThucAn
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public String Ma_mon_an { get; set; }
        public String Ten_mon_an { get; set; }
        public Int32 Gia { get; set; }

        public override String ToString()
        {
            return "test{" +
                    "_id=" + _id +
                    "Ma_mon_an='" + Ma_mon_an + '\'' +
                    ", Ten_mon_an'" + Ten_mon_an + '\'' +
                    ", Gia=" + Gia +
                    '}';
        }
    }
}
