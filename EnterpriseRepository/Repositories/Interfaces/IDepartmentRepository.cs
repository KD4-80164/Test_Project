using Enterprise.ORM.Entities.Entity;

namespace Enterprise.Services.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetAllDepartments();
    }
}
