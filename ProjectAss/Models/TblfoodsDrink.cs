using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class TblfoodsDrink
    {
        public TblfoodsDrink()
        {
            Tblorderdetails = new HashSet<Tblorderdetail>();
            Tblratings = new HashSet<Tblrating>();
        }

        public int FoodId { get; set; }
        public int MenuTypeId { get; set; }
        public string FoodName { get; set; }
        public string FoodCategory { get; set; }
        public string FoodSize { get; set; }
        public double FoodPrice { get; set; }
        public string FoodImage { get; set; }

        public virtual TblCategory MenuType { get; set; }
        public virtual ICollection<Tblorderdetail> Tblorderdetails { get; set; }
        public virtual ICollection<Tblrating> Tblratings { get; set; }
    }
}
