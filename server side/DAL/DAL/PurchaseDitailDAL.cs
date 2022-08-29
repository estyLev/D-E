using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Models;

namespace DAL
{
    public class PurchaseDitailDAL: IPurchaseDitailDAL
    {
        FurnitursContext mydb;
        public PurchaseDitailDAL(FurnitursContext mydb)
        {
            this.mydb = mydb;
        }
        public List<PurchaseDitail> AddPurchaseDitail(PurchaseDitail PurchaseDitail)
        {
            try
            {
                mydb.PurchaseDitails.Add(PurchaseDitail);
                mydb.SaveChanges();
                return mydb.PurchaseDitails.ToList();
            }
            catch
            {
                return mydb.PurchaseDitails.ToList();
            }
        }

        public List<PurchaseDitail> DeletePurchaseDitail(int idIdentity)
        {
            try
            {
                PurchaseDitail temp = mydb.PurchaseDitails.FirstOrDefault(u => u.IdIdentity  == idIdentity);
                mydb.PurchaseDitails.Remove(temp);
                mydb.SaveChanges();
                return mydb.PurchaseDitails.ToList();
            }
            catch
            {
                return mydb.PurchaseDitails.ToList();
            }
        }

        public List<PurchaseDitail> GetAllPurchaseDitails()
        {
            return mydb.PurchaseDitails.ToList();
        }

        public PurchaseDitail GetPurchaseDitailByCode(int idIdentity)
        {
            return mydb.PurchaseDitails.FirstOrDefault(u => u.IdIdentity == idIdentity);
        }

        public List<PurchaseDitail> UpdatePurchaseDitail(int idIdentity, PurchaseDitail PurchaseDitail)
        {
            try
            {
                PurchaseDitail temp = mydb.PurchaseDitails.FirstOrDefault(u => u.IdIdentity == idIdentity);
                mydb.PurchaseDitails.Remove(temp);
                mydb.PurchaseDitails.Add(PurchaseDitail);
                mydb.SaveChanges();
                return mydb.PurchaseDitails.ToList();
            }
            catch
            {
                return mydb.PurchaseDitails.ToList();
            }
        }
    }
}
