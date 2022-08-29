using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PurchaseDitail
    {
        public int IdIdentity { get; set; }
        public int PurchaseCode { get; set; }
        public int ProductCode { get; set; }
        public int? Amount { get; set; }

        public virtual Product ProductCodeNavigation { get; set; }
        public virtual Purchase PurchaseCodeNavigation { get; set; }
    }
}
