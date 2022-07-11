using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class Tblsiteinfo
    {
        public int SiteInfoId { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public string ContactInfo { get; set; }
        public string Address { get; set; }
        public DateTime LastUpdate { get; set; }
        public int UserId { get; set; }

        public virtual Tblemployee User { get; set; }
    }
}
