using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectAss.Logics;
using ProjectAss.Models;

namespace ProjectAss.Controllers
{
    public class AcountController : Controller
    {
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
            string action = "";
            if (summit != null)
            {
                string username = coleection["username"];
                string password = coleection["password"];
                string remember = coleection["rememberme"];
                Tblcustomer cus = CustomerManager.CheckLogin(username);
                Tblemployee emp = EmployeeManager.CheckLogin(username);
                if (cus != null)
                {
                    string cus2 = JsonConvert.SerializeObject(cus);
                    HttpContext.Session.SetString("cus",cus2);
                    return RedirectToAction("Index", "Home");
                }
                else if (emp != null)
                {
                    string admin = JsonConvert.SerializeObject(emp);
                    HttpContext.Session.SetString("admin", admin);
                    return RedirectToAction("Admin", "Employee", new { emp.UserId });
                }
                else
                {
                    ViewBag.error = "UserName or Password not correct";
                    action = "Login";
                }
            }
            return View(action);
        }
        [HttpPost]
        public IActionResult Register(IFormCollection coleection)
        {
            return RedirectToAction("Index","Home");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
