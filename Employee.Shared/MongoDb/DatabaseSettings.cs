using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Shared.MongoDb
{
    public class DatabaseSettings : IMongoDbSettings
    {
        public string ConnectionString { get; set; }
        public string LocalDatabaseName { get; set; }
        public string UserCollection { get; set; }
    }
}
