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
            prj_prnContext context = new prj_prnContext();
            context.Tblproducts.ToList();
            return context.Tblproducts.Where(x => x.MenuTypeId == id).ToList();
        }
        public List<Tblproduct> GetAllProducts()
        {
            prj_prnContext context = new prj_prnContext();
            context.Tblproducts.ToList();
            return context.Tblproducts.ToList();
        }
        public List<TblfoodSize> GetAllSizeOneFood(int id)
        {
            prj_prnContext context = new prj_prnContext();
            context.Tblproducts.ToList();
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
        public TblfoodSize GetAllSize(int id)
        {
            prj_prnContext context = new prj_prnContext();
            context.Tblproducts.ToList();
            return context.TblfoodSizes.FirstOrDefault(x => x.FoodSizeId == id);
        }
        public Tblproduct GetOneProduct(int id)
        {
            prj_prnContext context = new prj_prnContext();
            context.Tblproducts.ToList();
            return context.Tblproducts.Where(x => x.FoodId == id).FirstOrDefault();
        }
    }
}
