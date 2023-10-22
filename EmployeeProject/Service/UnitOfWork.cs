using Employee.Infrastructure.Service.Interface;
using Employee.Shared.Model;
using EmployeeProject.Service.Interface;
using MongoDB.Driver;

namespace EmployeeProject.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        public IMongoCollectionService _mongoservice;
        
        public UnitOfWork(IMongoCollectionService mongoCollectionService) 
        { 
            _mongoservice = mongoCollectionService;
        }

        public void AddUsers(Users users)
        {
            var result = _mongoservice.GetCollection<Users>("local", "Users");
            result.InsertOne(users);
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public List<Users> GetUsers()
        {
            var result = _mongoservice.GetCollection<Users>("local", "Users");
            return result.Find<Users>(u => true).ToList();
                //.FindAsync<List<Users>>();
                //.FindAsync<List<Users>>();
           // throw new NotImplementedException();
        }

        public List<Users> GetUsers(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
