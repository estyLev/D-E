using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ProductDTO
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CategoryCode { get; set; }
        public decimal Cost { get; set; }
        public string Picture { get; set; }
    }
}
