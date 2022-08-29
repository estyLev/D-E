using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DTO
{
    public class PurchaseDTO
    {
        public int PurchaseCode { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int UserCode { get; set; }
        public int? Sum { get; set; }

    }
}
