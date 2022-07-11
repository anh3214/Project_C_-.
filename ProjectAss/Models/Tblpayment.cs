using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class Tblpayment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public double Amount { get; set; }
        public string PaidBy { get; set; }
        public DateTime PaymentDate { get; set; }
        public int ProcessedBy { get; set; }

        public virtual Tblorder Order { get; set; }
        public virtual Tblemployee ProcessedByNavigation { get; set; }
    }
}
