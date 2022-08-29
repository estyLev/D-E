using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DTO
{
    public class AutoProduct : AutoMapper.Profile
    {
        public AutoProduct()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
        }
    }
}
