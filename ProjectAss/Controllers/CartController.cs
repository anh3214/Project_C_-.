using Microsoft.AspNetCore.Mvc;

namespace ProjectAss.Controllers
{
    public class CartController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
