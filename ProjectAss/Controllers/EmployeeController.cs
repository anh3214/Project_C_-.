using Microsoft.AspNetCore.Mvc;

namespace ProjectAss.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
