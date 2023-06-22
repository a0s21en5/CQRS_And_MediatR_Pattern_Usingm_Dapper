using Dapper;
using Employee_Web_Application.Exception;
using Employee_Web_Application.Models;
using Employee_Web_Application.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace Employee_Web_Application.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _connectionString;
        public EmployeeRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                string sQuery = "select * from Employee";
                List<Employee> AllEmployee = (await dbConnection.QueryAsync<Employee>(sQuery)).ToList();
                if (AllEmployee.Count > 0)
                {
                    return AllEmployee;
                }
                else
                {
                    throw new EmptyListExecption($"Your List Is Empty");
                }
            }
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                string sQuery = "select * from Employee Where EmployeeId = @Id";
                Employee Allmployee = await dbConnection.QueryFirstOrDefaultAsync<Employee>(sQuery, new { id });
                if (Allmployee != null)
                {
                    return Allmployee;
                }
                else
                {
                    throw new EmptyListExecption($"Your List Is Empty");
                }
            }
        }
    }
}
