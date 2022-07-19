using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAss.Logics;
using ProjectAss.Models;

namespace ProjectAss.Controllers
{
    public class HomeController : Controller
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
            string action="";
            if (summit != null)
            {
                string username = coleection["username"];
                string password = coleection["password"];
                string remember = coleection["rememberme"];
                Tblcustomer cus = CustomerManager.CheckLogin(username);
                Tblemployee emp = EmployeeManager.CheckLogin(username);
                if (cus != null)
                {
                    action = "Index";
                }
                else if (emp != null)
                {
                    return RedirectToAction("Admin","Employee");
                }
                else
                {
                    action = "Login";
                }
            }
            return RedirectToAction(action);
        }
        [HttpPost]
        public IActionResult Register(IFormCollection coleection)
        {
            return RedirectToAction("Index");
        }
    }
}
