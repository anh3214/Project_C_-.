using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class Tblrating
    {
        public int RatingId { get; set; }
        public int FoodId { get; set; }
        public int Score { get; set; }
        public string Remarks { get; set; }
        public DateTime DateRecorded { get; set; }
        public int CustomerId { get; set; }

        public virtual Tblcustomer Customer { get; set; }
        public virtual Tblproduct Food { get; set; }
    }
}
