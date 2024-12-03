using Enterprise.Services.Managers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Test_Project.Controllers
{
    [Route("employee")]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeManager employeeManager;
        public EmployeeController(IEmployeeManager employeeManager)
        {
            this.employeeManager = employeeManager;
        }

        [HttpGet("all-employees")]
        public IActionResult GetAllEmployees()
        {
            var emps = employeeManager.GetAllEmployees();
            return Ok(emps.Result);
        }
    }
}
