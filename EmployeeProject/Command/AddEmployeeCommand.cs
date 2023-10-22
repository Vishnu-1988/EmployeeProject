using Employee.Shared.Model;
using MediatR;

namespace EmployeeProject.Command
{
    public record AddEmployeeCommand(Users employee):IRequest;
   
}
