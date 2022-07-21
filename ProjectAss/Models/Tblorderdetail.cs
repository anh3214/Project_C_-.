using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class Tblorderdetail
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public double Amount { get; set; }
        public double TotalAmount { get; set; }

        public virtual Tblproduct Food { get; set; }
        public virtual Tblorder Order { get; set; }
    }
}
