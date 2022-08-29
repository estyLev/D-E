using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;


namespace DTO
{
    public class AutoPurchase: AutoMapper.Profile
    {
        public AutoPurchase()
        {
            CreateMap<Purchase, PurchaseDTO>();
            CreateMap<PurchaseDTO, Purchase>();
        }
    }
}
