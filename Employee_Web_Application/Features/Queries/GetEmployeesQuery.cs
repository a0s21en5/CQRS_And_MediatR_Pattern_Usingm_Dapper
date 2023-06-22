using Employee_Web_Application.Models;
using MediatR;

namespace Employee_Web_Application.Features.Queries
{
    public class GetEmployeesQuery : IRequest<List<Employee>>
    {
    }
}
