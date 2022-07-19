using Microsoft.AspNetCore.Mvc;

namespace ProjectAss.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
