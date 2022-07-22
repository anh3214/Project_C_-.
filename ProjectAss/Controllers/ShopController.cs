using Microsoft.AspNetCore.Mvc;
using ProjectAss.Models;
using ProjectAss.Logics;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Newtonsoft.Json;

namespace ProjectAss.Controllers
{
    public class ShopController : Controller
    {

        CategoryManager cate = new CategoryManager();
        FoodManager food = new FoodManager();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Shoping(int id)
        {
            string cartcheck = HttpContext.Session.GetString("cart");
            Dictionary<int, int> cart = new Dictionary<int, int>();
            int count = 0;
            if (cartcheck != null)
            {
                cart = JsonConvert.DeserializeObject<Dictionary<int, int>>(cartcheck);
                count = cart.Count;
            }
            List<Tblproduct> list;
            List<TblfoodSize> listFoodSize;
            List<TblCategory> listCa;
            ViewBag.count = count;
            list = food.GetAllProductsByType(id);
            listFoodSize = food.GetAllSizeOneFood(id);
            listCa = cate.GetAllCategory();
            ViewBag.size = listFoodSize;
            ViewBag.category = listCa;
            return View(list);
        }
        public IActionResult Details(int type, int id)
        {
            string cartcheck = HttpContext.Session.GetString("cart");
            Dictionary<int, int> cart = new Dictionary<int, int>();
            int count = 0;
            if (cartcheck != null)
            {
                cart = JsonConvert.DeserializeObject<Dictionary<int, int>>(cartcheck);
                count = cart.Count;
            }
            List<Tblproduct> list;
            List<TblfoodSize> listFoodSize;
            ViewBag.count = count;
            list = food.GetAllProducts();
            listFoodSize = food.GetAllSizeOneFood(type);

            ViewBag.size = listFoodSize;
            ViewBag.category = cate.GetAllCategory();

            ViewBag.food = list.Where(x => x.MenuTypeId == type).ToList();
            Tblproduct food3 = list.FirstOrDefault(x => x.FoodId == id);
            return View(food3);
        }
        public IActionResult Search(IFormCollection collection)
        {
            return View();
        }
    }
}
