using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectAss.Logics;
using ProjectAss.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAss.Controllers
{
    public class CartController : Controller
    {
        FoodManager foodM = new FoodManager();
        public IActionResult List()
        {
            prj_prnContext context = new prj_prnContext();
            context.Tblproducts.ToList();
            List<int> quantity = new List<int>();
            List<TblfoodSize> size = new List<TblfoodSize>();
            string cartcheck = HttpContext.Session.GetString("cart");
            Dictionary<int, int> cart = new Dictionary<int, int>();
            if (cartcheck != null)
            {
                cart = JsonConvert.DeserializeObject<Dictionary<int, int>>(cartcheck);
                foreach (int key in cart.Keys)
                {
                    TblfoodSize s = foodM.GetAllSize(key);
                    size.Add(s);
                    quantity.Add(cart[key]);
                }
            }
            ViewBag.size = size;
            ViewBag.quantity = quantity;
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string AddToCart(IFormCollection collection)
        {
            int food_id = Convert.ToInt32(collection["product_id"]);
            int food_type = Convert.ToInt32(collection["size"]);
            if(foodM.GetAllSize(food_type) != null)
            {
                int amount = Convert.ToInt32(collection["quantity"]);
                string cartcheck = HttpContext.Session.GetString("cart");
                if (cartcheck != null)
                {
                    Dictionary<int, int> cart = JsonConvert.DeserializeObject<Dictionary<int, int>>(cartcheck);
                    if (cart.ContainsKey(food_type))
                    {

                        int quatity = cart[food_type] + amount;
                        cart[food_type] = quatity;
                    }
                    else
                    {
                        cart.Add(food_type, amount);
                    }
                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
                }
                else
                {
                    Dictionary<int, int> cart = new Dictionary<int, int>();
                    cart.Add(food_type, amount);
                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));

                }
                return "Done";
            }
            else
            {
                return "Fails";
            }
        }
    }
}
