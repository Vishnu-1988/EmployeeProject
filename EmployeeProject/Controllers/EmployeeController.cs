using Employee.Shared.Model;
using EmployeeProject.Command;
using EmployeeProject.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController :  ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<Users>> Get()
        {
            return await _mediator.Send(new GetEmployeeListQuery());
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody]Users employee)
        {
            await _mediator.Send(new AddEmployeeCommand(employee));
            return StatusCode(201);
        }
    }
}
