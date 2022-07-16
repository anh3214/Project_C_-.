using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAss.Logics;

namespace ProjectAss.Controllers
{
    public class HomeController : Controller
    {
        CategoryManager categor;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(IFormCollection coleection)
        {
            string summit = coleection["login"];
            if (summit == null)
                return View("Login");
            else
                return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Register(IFormCollection coleection)
        {
            return RedirectToAction("Index");
        }
    }
}
