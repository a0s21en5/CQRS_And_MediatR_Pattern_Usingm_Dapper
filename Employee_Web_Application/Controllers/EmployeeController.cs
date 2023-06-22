using Employee_Web_Application.Exception;
using Employee_Web_Application.Features.Queries;
using Employee_Web_Application.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Web_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //Get All Employee
        [Route("Get")]
        [HttpGet]
        public async Task<ActionResult> GetEmployeesAsync()
        {
            try
            {
                List<Employee> AllEmployee = await _mediator.Send(new GetEmployeesQuery());
                return Ok(AllEmployee);
            }
            catch (EmptyListExecption ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //Get Employee By Id
        [Route("Details/{id}")]
        [HttpGet]
        public async Task<ActionResult> GetEmployeeAsync(int id)
        {
            try
            {
                Employee employee = await _mediator.Send(new GetEmployeeQuery() { Id = id });
                return Ok(employee);
            }
            catch (EmptyListExecption ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

