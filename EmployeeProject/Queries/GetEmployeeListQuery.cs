using Employee.Shared.Model;
using MediatR;

namespace EmployeeProject.Queries
{
    // C# 9 feature of record 
    public record GetEmployeeListQuery():IRequest<List<Users>>;
   
}
