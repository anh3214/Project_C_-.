﻿using Microsoft.AspNetCore.Mvc;

namespace ProjectAss.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Admin(int id)
        {
            return View();
        }
    }
}
