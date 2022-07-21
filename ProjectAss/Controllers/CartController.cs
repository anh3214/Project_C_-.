using Microsoft.AspNetCore.Mvc;
using ProjectAss.Models;
using System.Collections.Generic;

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
