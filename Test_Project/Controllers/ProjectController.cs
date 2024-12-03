using EnterpriseRepository.Entities.AppDBContext;
using Microsoft.AspNetCore.Mvc;

namespace Test_Project.Controllers
{
    [Route("projects")]
    public class ProjectController : ControllerBase
    {
        public readonly ApplicationDBContext _context;

        public ProjectController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("all-projects")]
        public IActionResult GetAllProjects()
        {
            var projects = _context.Projects.ToList();
            return Ok(projects);
        }
    }
}
