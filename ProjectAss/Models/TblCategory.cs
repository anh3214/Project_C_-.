using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAss.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            Tblproducts = new HashSet<Tblproduct>();
        }

        public int FoodTypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Tblproduct> Tblproducts { get; set; }
    }
}
