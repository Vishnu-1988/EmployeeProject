using Employee.Shared.Model;

namespace EmployeeProject.Service.Interface
{
    public interface IUnitOfWork
    {
        List<Users> GetUsers();
        List<Users> GetUsers(string Name);
        void AddUsers(Users users);
        int GetCount();
    }
}
