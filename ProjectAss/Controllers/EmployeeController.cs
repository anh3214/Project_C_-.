using Microsoft.AspNetCore.Mvc;
using ProjectAss.Ults;

namespace ProjectAss.Controllers
{
    public class EmployeeController : Controller
    {
        [Middlewares]
        public IActionResult Admin()
        {
            return View();
        }
        [Middlewares]
        public IActionResult ProductList()
        {
            return View();
        }
        [Middlewares]
        public IActionResult ProductDetail()
        {
            return View();
        }
        [Middlewares]
        public IActionResult AddProduct()
        {
            return View();
        }
        [Middlewares]
        public IActionResult CustomerList()
        {
            return View();
        }
        [Middlewares]
        public IActionResult RatingList()
        {
            return View();
        }
        [Middlewares]
        public IActionResult OrderList()
        {
            return View();
        }
    }
}
