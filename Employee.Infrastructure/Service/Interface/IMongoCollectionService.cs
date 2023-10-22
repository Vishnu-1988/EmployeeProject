using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Service.Interface
{
    public interface IMongoCollectionService
    {
        IMongoCollection<T> GetCollection<T>(string databaseName,string collectionName);
        //int AddDocument<T>(string collectionName, T document);
    }
}
