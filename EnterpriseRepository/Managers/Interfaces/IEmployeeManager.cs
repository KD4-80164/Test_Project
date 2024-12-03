using Enterprise.ORM.Entities.Entity;

namespace Enterprise.Services.Managers.Interfaces
{
    public interface IEmployeeManager
    {
        Task<List<Employee>> GetAllEmployees();
    }
}
