using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class Tblproduct
    {
        public Tblproduct()
        {
            TblfoodSizes = new HashSet<TblfoodSize>();
            Tblorderdetails = new HashSet<Tblorderdetail>();
            Tblratings = new HashSet<Tblrating>();
        }

        public int FoodId { get; set; }
        public int MenuTypeId { get; set; }
        public string FoodName { get; set; }
        public string FoodCategory { get; set; }
        public string FoodDescription { get; set; }
        public string FoodImage { get; set; }

        public virtual TblCategory MenuType { get; set; }
        public virtual ICollection<TblfoodSize> TblfoodSizes { get; set; }
        public virtual ICollection<Tblorderdetail> Tblorderdetails { get; set; }
        public virtual ICollection<Tblrating> Tblratings { get; set; }
    }
}
