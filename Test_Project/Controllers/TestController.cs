using Microsoft.AspNetCore.Mvc;

namespace Test_Project.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
