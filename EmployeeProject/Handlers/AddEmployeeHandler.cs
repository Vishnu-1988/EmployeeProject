using EmployeeProject.Command;
using EmployeeProject.Service.Interface;
using MediatR;

namespace EmployeeProject.Handlers
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddEmployeeHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.AddUsers(request.employee);
            return;
            //throw new NotImplementedException();
        }
    }
}
