using ProjectAss.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAss.Logics
{
    public class CategoryManager
    {
        prj_prnContext context;
        public CategoryManager()
        {
            context = new prj_prnContext();
        }
        public List<TblCategory> GetAllCategory()
        {
            return context.TblCategories.ToList();
        }
    }
}
