using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class Tblcustomer
    {
        public Tblcustomer()
        {
            Tblorders = new HashSet<Tblorder>();
            Tblratings = new HashSet<Tblrating>();
        }

        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerMiddleName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerLandline { get; set; }
        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }

        public virtual ICollection<Tblorder> Tblorders { get; set; }
        public virtual ICollection<Tblrating> Tblratings { get; set; }
    }
}
