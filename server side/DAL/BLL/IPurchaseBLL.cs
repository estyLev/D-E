using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL
{
    public interface IPurchaseBLL
    {
        public List<PurchaseDTO> GetAllPurchases();
        public PurchaseDTO GetPurchaseByCode(int Code);
        public List<PurchaseDTO> AddPurchase(PurchaseDTO Purchase);
        public List<PurchaseDTO> UpdatePurchase(int Code, PurchaseDTO Purchase);
        public List<PurchaseDTO> DeletePurchase(int Code);
    }
}
