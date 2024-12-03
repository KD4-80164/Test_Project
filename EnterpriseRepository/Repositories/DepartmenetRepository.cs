using Enterprise.ORM.Entities.Entity;
using EnterpriseRepository.Entities.AppDBContext;
using Enterprise.Services.Repositories.Interfaces;

namespace Enterprise.Services.Repositories
{
    public class DepartmenetRepository : IDepartmentRepository
    {
        public readonly ApplicationDBContext _context;
        public DepartmenetRepository(ApplicationDBContext context)
        {
            _context = context;
        }


        public async Task<List<Department>> GetAllDepartments()
        {
            try
            {
                var departments =  _context.Departments.ToList();
                return departments;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
