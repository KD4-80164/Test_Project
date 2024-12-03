using Enterprise.ORM.Entities.Entity;
using Enterprise.Services.Repositories.Interfaces;
using EnterpriseRepository.Entities.AppDBContext;

namespace Enterprise.Services.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly ApplicationDBContext _context;

        public EmployeeRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            try
            {
                var employees = _context.Employees.ToList();
                return employees;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
