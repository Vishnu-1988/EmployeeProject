using Employee.Shared.Model;

namespace EmployeeProject.Service.Interface
{
    public interface IUnitOfWork
    {
        List<Users> GetUsers();
        List<Users> GetUsers(string Name);
        int GetCount();
    }
}
