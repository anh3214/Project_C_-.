using Microsoft.AspNetCore.Mvc;

namespace ProjectAss.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View("Login");
        }
    }
}
