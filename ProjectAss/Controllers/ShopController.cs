using Microsoft.AspNetCore.Mvc;
using ProjectAss.Models;
using ProjectAss.Logics;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace ProjectAss.Controllers
{
    public class ShopController : Controller
    {
        List<Tblproduct> list;
        List<TblfoodSize> listFoodSize;
        List<TblCategory> listCa;
        CategoryManager cate = new CategoryManager();
        FoodManager food = new FoodManager();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Shoping(int id)
        {
            list = food.GetAllProductsByType(id);
            listFoodSize = food.GetAllSize(id);
            listCa = cate.GetAllCategory();
            ViewBag.size = listFoodSize;
            ViewBag.category = listCa;
            return View(list);
        }
        public IActionResult Details(int id,int type)
        {
            list = food.GetAllProducts();
            listFoodSize = food.GetAllSize(id);
            ViewBag.size = listFoodSize;
            ViewBag.category = cate.GetAllCategory();
            ViewBag.food = list.Where(x => x.MenuTypeId == type).ToList();
            Tblproduct food3 = list.Where(x => x.FoodId == id).FirstOrDefault();
            return View(food3);
        }
        public IActionResult AddToCart()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Search(IFormCollection collection)
        {
            return View();
        }
    }
}
