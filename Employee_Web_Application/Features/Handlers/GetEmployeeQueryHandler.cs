using Employee_Web_Application.Features.Queries;
using Employee_Web_Application.Models;
using Employee_Web_Application.Repositories.Interfaces;
using MediatR;

namespace Employee_Web_Application.Features.Handlers
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Employee> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeAsync(request.Id);
        }
    }
}
