using ProjectAss.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAss.Logics
{
    public class FoodManager
    {
        prj_prnContext context;
        public FoodManager()
        {
            context = new prj_prnContext();
        }
        public List<Tblproduct> GetAllProductsByType(int id)
        {
            return context.Tblproducts.Where(x => x.MenuTypeId == id).ToList();
        }
        public List<Tblproduct> GetAllProducts()
        {
            return context.Tblproducts.ToList();
        }
        public List<TblfoodSize> GetAllSize(int id)
        {
            List<TblfoodSize> Allsize = context.TblfoodSizes.ToList();
            List<Tblproduct> food = GetAllProductsByType(id);
            List<TblfoodSize> size = new List<TblfoodSize>();
            foreach (Tblproduct product in food)
            {
                foreach(TblfoodSize siz3 in Allsize)
                {
                    if(product.FoodId == siz3.FoodId)
                    {
                        size.Add(siz3);
                    }
                }              
            }
            return size;
        }
    }
}
