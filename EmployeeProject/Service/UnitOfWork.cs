using Employee.Shared.Model;
using EmployeeProject.Service.Interface;

namespace EmployeeProject.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public List<Users> GetUsers()
        {
            throw new NotImplementedException();
        }

        public List<Users> GetUsers(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
