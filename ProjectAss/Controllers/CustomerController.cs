using Microsoft.AspNetCore.Mvc;
using ProjectAss.Models;
using System.Collections.Generic;

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
