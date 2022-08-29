using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL
{
    public interface IPurchaseDitailDAL
    {
        public List<PurchaseDitail> GetAllPurchaseDitails();
        public PurchaseDitail GetPurchaseDitailByCode(int idIdentity);
        public List<PurchaseDitail> AddPurchaseDitail(PurchaseDitail PurchaseDitail);
        public List<PurchaseDitail> UpdatePurchaseDitail(int idIdentity, PurchaseDitail PurchaseDitail);
        public List<PurchaseDitail> DeletePurchaseDitail(int idIdentity);
    }
}
