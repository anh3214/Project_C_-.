using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class Tblemployee
    {
        public Tblemployee()
        {
            Tblorders = new HashSet<Tblorder>();
            Tblpayments = new HashSet<Tblpayment>();
            Tblsiteinfos = new HashSet<Tblsiteinfo>();
        }

        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Contact { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Tblorder> Tblorders { get; set; }
        public virtual ICollection<Tblpayment> Tblpayments { get; set; }
        public virtual ICollection<Tblsiteinfo> Tblsiteinfos { get; set; }
    }
}
