using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class Tblorder
    {
        public Tblorder()
        {
            Tblorderdetails = new HashSet<Tblorderdetail>();
            Tblpayments = new HashSet<Tblpayment>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public int OrderStatus { get; set; }
        public int ProcessedBy { get; set; }

        public virtual Tblcustomer Customer { get; set; }
        public virtual Tblemployee ProcessedByNavigation { get; set; }
        public virtual ICollection<Tblorderdetail> Tblorderdetails { get; set; }
        public virtual ICollection<Tblpayment> Tblpayments { get; set; }
    }
}
