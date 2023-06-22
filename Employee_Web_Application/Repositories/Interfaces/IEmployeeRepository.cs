
using Employee_Web_Application.Models;

namespace Employee_Web_Application.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeAsync(int id);
        Task<List<Employee>> GetEmployeesAsync();
    }
}
