using Enterprise.ORM.Entities.Entity;

namespace Enterprise.Services.Managers.Interfaces
{
    public interface IDepartmentManager
    {
        Task<List<Department>> GetAllDepartments();
    }
}
