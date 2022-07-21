using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class TblfoodSize
    {
        public int FoodId { get; set; }
        public string FoodSize { get; set; }
        public float FoodPrice { get; set; }

        public virtual Tblproduct Food { get; set; }
    }
}
