using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL
{
    public interface IPurchaseDAL
    {
        public List<Purchase> GetAllPurchases();
        public Purchase GetPurchaseByCode(int Code);
        public List<Purchase> AddPurchase(Purchase Purchase);
        public List<Purchase> UpdatePurchase(int Code, Purchase Purchase);
        public List<Purchase> DeletePurchase(int Code);
    }
}
