using Microsoft.AspNetCore.Mvc;

namespace ProjectAss.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
