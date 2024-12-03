using Enterprise.Services.Managers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Test_Project.Controllers
{
    [Route("department")]
    public class DepartmentController : ControllerBase
    {
        public readonly IDepartmentManager departmentManager;
        public DepartmentController(IDepartmentManager departmentManager) 
        {
            this.departmentManager = departmentManager;
        }
        [HttpGet]
        [Route("all-departments")]
        public IActionResult GetAllDepartment()
        {
            var res = departmentManager.GetAllDepartments();
            return Ok(res.Result);
        }
    }
}
