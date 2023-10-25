using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachHangGUI.DAO
{
    internal class ThucAn:db
    {
        private const string CollectionName = "Mon_an";

        private IMongoCollection<DTO.ThucAn> Collection()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<DTO.ThucAn> c = d.GetCollection<DTO.ThucAn>(CollectionName);
            return c;
        }
        public List<DTO.ThucAn> DSMonAn()
        {
            IMongoCollection<DTO.ThucAn> collection = Collection();
            var filter = Builders<DTO.ThucAn>.Filter.Empty;

            List<DTO.ThucAn> thucAnList = collection.Find(filter).ToList();

            return thucAnList;
        }
        
    }
}
