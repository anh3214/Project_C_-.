using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectAss.Logics;
using ProjectAss.Models;
using System.Collections.Generic;

namespace ProjectAss.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            CategoryManager cate = new CategoryManager();
            List<TblCategory> list = cate.GetAllCategory();
            string cus = HttpContext.Session.GetString("cus");
            string cartcheck = HttpContext.Session.GetString("cart");
            Dictionary<int, int> cart = new Dictionary<int, int>();
            int count = 0;
            if (cartcheck != null)
            {
                cart = JsonConvert.DeserializeObject<Dictionary<int, int>>(cartcheck);
                count = cart.Count;
            }
            ViewBag.count = count;
            if (cus != null)
            {
                Tblcustomer a = JsonConvert.DeserializeObject<Tblcustomer>(cus);
                ViewBag.customer = a;
            }
            return View(list);
        }
    }
}
