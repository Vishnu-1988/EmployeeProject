using Employee.Shared.Model;
using EmployeeProject.Queries;
using EmployeeProject.Service.Interface;
using MediatR;

namespace EmployeeProject.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<Users>>
    {
        public readonly IUnitOfWork _unitOfWork;
        public GetEmployeeListHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<List<Users>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
           return Task.FromResult(_unitOfWork.GetUsers());
           // throw new NotImplementedException();
        }
    }

}
