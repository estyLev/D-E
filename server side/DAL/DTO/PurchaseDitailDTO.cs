using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class PurchaseDitailDTO
    {
        public int IdIdentity { get; set; }
        public int PurchaseCode { get; set; }
        public int ProductCode { get; set; }
        public int? Amount { get; set; }
    }
}
