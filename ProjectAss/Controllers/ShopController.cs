using Microsoft.AspNetCore.Mvc;

namespace ProjectAss.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Shoping()
        {
            return View();
        }
    }
}
