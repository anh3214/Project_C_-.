using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblfoodsDrinks = new HashSet<TblfoodsDrink>();
        }

        public int FoodTypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TblfoodsDrink> TblfoodsDrinks { get; set; }
    }
}
