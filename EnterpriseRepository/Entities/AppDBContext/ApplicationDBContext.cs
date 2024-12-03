using Enterprise.ORM.Entities.Entity;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseRepository.Entities.AppDBContext
{
    public class ApplicationDBContext : DbContext
    {
            public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
            {

            }

            public DbSet<Project> Projects { get; set; }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Department> Departments { get; set; }

        }
}
