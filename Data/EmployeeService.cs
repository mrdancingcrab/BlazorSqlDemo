using BlazorSql.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorSql.Data
{
	public class EmployeeService
	{
		private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeService(EmployeeDbContext context)
        {
            _employeeDbContext = context;
        }

        public async Task AddEmployee(Employee employee)
        {
            _employeeDbContext.Employees.Add(employee);
            await _employeeDbContext.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _employeeDbContext.Employees.ToListAsync();
        }
    }
}
