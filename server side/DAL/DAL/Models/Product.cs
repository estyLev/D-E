using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Product
    {
        public Product()
        {
            PurchaseDitails = new HashSet<PurchaseDitail>();
        }

        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CategoryCode { get; set; }
        public decimal Cost { get; set; }
        public string Picture { get; set; }

        public virtual Category CategoryCodeNavigation { get; set; }
        public virtual ICollection<PurchaseDitail> PurchaseDitails { get; set; }
    }
}
