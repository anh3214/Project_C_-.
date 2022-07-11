using Microsoft.AspNetCore.Mvc;

namespace ProjectAss.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View("Login.cshtml");
        }
    }
}
