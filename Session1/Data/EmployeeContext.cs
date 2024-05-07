using Microsoft.EntityFrameworkCore;
using Session1.Models;

namespace Session1.Data
{
    public class EmployeeContext : DbContext
    {
         public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("server=DESKTOP-2VPR9IB;database=session1;trusted_connection=true;TrustServerCertificate=True");
        }
    }
}
