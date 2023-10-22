using Employee.Infrastructure.Service.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Service
{
    public class MongoCollectionService : IMongoCollectionService
    {
        private readonly IMongoClient _client;
        public MongoCollectionService(IMongoClient mongoClient)
        {
            _client = mongoClient;
        }

        //public int AddDocument<T>(string collectionName, T document)
        //{
        //    //_client.
        //    throw new NotImplementedException();
        //}

        public IMongoCollection<T> GetCollection<T>(string databaseName, string collectionName)
        {
            return _client.GetDatabase(databaseName).GetCollection<T>(collectionName);
        }
    }
}
