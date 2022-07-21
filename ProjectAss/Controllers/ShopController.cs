using Microsoft.AspNetCore.Mvc;
using ProjectAss.Models;
using ProjectAss.Logics;
using System.Collections.Generic;

namespace ProjectAss.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Shoping(int id)
        {
            CategoryManager cate = new CategoryManager();
            FoodManager food = new FoodManager();
            List<Tblproduct> list = food.GetAllProducts(id);
            List<TblfoodSize> listFoodSize = food.GetAllSize(id);
            List<TblCategory> listCa = cate.GetAllCategory();
            ViewBag.size = listFoodSize;
            ViewBag.category = listCa;
            return View(list);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
