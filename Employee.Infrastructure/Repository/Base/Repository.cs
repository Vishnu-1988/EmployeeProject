using Employee.Infrastructure.Service.Interface;
using Employee.Shared.Model;
using Employee.Shared.MongoDb;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Repository.Base
{
    public abstract class Repository<T>:IRepository where T : class
    {
        protected abstract IMongoCollection<T> collection { get; }
        private readonly DatabaseSettings _settings;
        protected readonly IMongoCollectionService _mongoCollectionService;
        public Repository(IMongoCollectionService mongoCollectionService, IOptions<DatabaseSettings> option)
        {
           
            _settings=option.Value;
            _mongoCollectionService = mongoCollectionService;
               

        }

       public virtual async Task<bool> Any()
        {
            var count = await collection.Find(FilterDefinition<T>.Empty).CountAsync();
            return count > 0;
        }
    }

    public interface IRepository
    {
    }
}
