using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DTO
{
    public class AutoPurchaseDitail: AutoMapper.Profile
    {
        public AutoPurchaseDitail()
        {
            CreateMap<PurchaseDitail, PurchaseDitailDTO>();
            CreateMap<PurchaseDitailDTO, PurchaseDitail>();
        }
    }
}
