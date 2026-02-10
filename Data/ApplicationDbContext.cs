using EMPLOYEEMANAGEMENT.Models;
using Microsoft.EntityFrameworkCore;
namespace EMPLOYEEMANAGEMENT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Employee> Employees{get;set;}
    }
}