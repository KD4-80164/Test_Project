using Enterprise.ORM.Entities.Entity;
using Enterprise.Services.Managers.Interfaces;
using Enterprise.Services.Repositories;
using Enterprise.Services.Repositories.Interfaces;

namespace Enterprise.Services.Managers
{
    public class EmployeeManager : IEmployeeManager
    {
        public readonly IEmployeeRepository employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Task<List<Employee>> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees();
        }
    }
}
