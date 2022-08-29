using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL
{
   public interface IPurchaseDitailBLL
    {
        public List<PurchaseDitailDTO> GetAllPurchaseDitails();
        public PurchaseDitailDTO GetPurchaseDitailByCode(int idIdentity);
        public List<PurchaseDitailDTO> AddPurchaseDitail(PurchaseDitailDTO PurchaseDitail);
        public List<PurchaseDitailDTO> UpdatePurchaseDitail(int idIdentity, PurchaseDitailDTO PurchaseDitail);
        public List<PurchaseDitailDTO> DeletePurchaseDitail(int idIdentity);
    }

}
