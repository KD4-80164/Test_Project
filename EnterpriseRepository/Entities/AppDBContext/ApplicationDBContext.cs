using Enterprise.ORM.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
