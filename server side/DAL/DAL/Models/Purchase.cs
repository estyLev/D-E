using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Purchase
    {
        public Purchase()
        {
            PurchaseDitails = new HashSet<PurchaseDitail>();
        }

        public int PurchaseCode { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int UserCode { get; set; }
        public int? Sum { get; set; }

        public virtual User UserCodeNavigation { get; set; }
        public virtual ICollection<PurchaseDitail> PurchaseDitails { get; set; }
    }
}
