using Enterprise.ORM.Entities.Entity;
using Enterprise.Services.Managers.Interfaces;
using Enterprise.Services.Repositories.Interfaces;

namespace Enterprise.Services.Managers
{
    public class DepartmentManager : IDepartmentManager
    {
        public readonly IDepartmentRepository departmentRepository;

        public DepartmentManager(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        public Task<List<Department>> GetAllDepartments()
        {
            return departmentRepository.GetAllDepartments();
        }
    }
}
