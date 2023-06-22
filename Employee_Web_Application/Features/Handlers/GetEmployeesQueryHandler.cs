using Employee_Web_Application.Features.Queries;
using Employee_Web_Application.Models;
using Employee_Web_Application.Repositories.Interfaces;
using MediatR;

namespace Employee_Web_Application.Features.Handlers
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeesQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeesAsync();
        }
    }
}
