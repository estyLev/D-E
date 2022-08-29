using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using System.Linq;

namespace DAL
{
    public class PurchaseDAL:IPurchaseDAL
    {

        FurnitursContext mydb;
        public PurchaseDAL(FurnitursContext mydb)
        {
            this.mydb = mydb;
        }
        public  List<Purchase> AddPurchase(Purchase Purchase)
        {
            try
            {
                mydb.Purchases.Add(Purchase);
                mydb.SaveChanges();
                return mydb.Purchases.ToList();
            }
            catch
            {
                return mydb.Purchases.ToList();
            }
        }

        public  List<Purchase> DeletePurchase(int Code)
        {
            try
            {
                Purchase temp = mydb.Purchases.FirstOrDefault(u => u.PurchaseCode == Code);
                mydb.Purchases.Remove(temp);
                mydb.SaveChanges();
                return mydb.Purchases.ToList();
            }
            catch
            {
                return mydb.Purchases.ToList();
            }
        }

        public List<Purchase> GetAllPurchases()
        {
            return mydb.Purchases.ToList();
        }

        public Purchase GetPurchaseByCode(int Code)
        {
            return mydb.Purchases.FirstOrDefault(u => u.PurchaseCode == Code);
        }

        public  List<Purchase> UpdatePurchase(int Code, Purchase Purchase)
        {
            try
            {
                Purchase temp = mydb.Purchases.FirstOrDefault(u => u.PurchaseCode == Code);
                mydb.Purchases.Remove(temp);
                mydb.Purchases.Add(Purchase);
                mydb.SaveChanges();
                return mydb.Purchases.ToList();
            }
            catch
            {
                return mydb.Purchases.ToList();
            }
        }
    }
}
