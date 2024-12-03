using Enterprise.ORM.Entities.Entity;

namespace Enterprise.Services.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployees();
    }
}
