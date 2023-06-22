using Employee_Web_Application.Models;
using MediatR;

namespace Employee_Web_Application.Features.Queries
{
    public class GetEmployeeQuery :IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
