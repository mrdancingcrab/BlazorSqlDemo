using BlazorSql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;

namespace BlazorSql.Data
{
	public class EmployeeDbContext : DbContext
	{       
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base (options) { }

        public DbSet<Employee> Employees { get; set; } //Detta skapar tabellen i vår databas          
    }
}
