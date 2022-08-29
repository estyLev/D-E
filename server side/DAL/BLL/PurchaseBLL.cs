using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL.Models;
using DAL;
using AutoMapper;
using System.Linq;

namespace BLL
{
    
       public class PurchaseBLL : IPurchaseBLL
    {
        IPurchaseDAL PurchaseDal;
        IMapper imapper;

        public PurchaseBLL(IPurchaseDAL PurchaseDal)
        {
            this.PurchaseDal = PurchaseDal;

            var config = new MapperConfiguration(cnf => cnf.AddProfile<AutoPurchase>());
            imapper = config.CreateMapper();
        }
        public List<PurchaseDTO> AddPurchase(PurchaseDTO Purchase)
        {
            try
            {
                Purchase u = imapper.Map<PurchaseDTO, Purchase>(Purchase);
                List<Purchase> list = PurchaseDal.AddPurchase(u);
                return imapper.Map<List<Purchase>, List<PurchaseDTO>>(list);

            }
            catch
            {
                List<Purchase> list = PurchaseDal.GetAllPurchases();
                return imapper.Map<List<Purchase>, List<PurchaseDTO>>(list);
            }
        }

        public List<PurchaseDTO> DeletePurchase(int Code)
        {
            try
            {
                List<Purchase> list = PurchaseDal.DeletePurchase(Code);
                return imapper.Map<List<Purchase>, List<PurchaseDTO>>(list);

            }
            catch
            {
                List<Purchase> list = PurchaseDal.GetAllPurchases();
                return imapper.Map<List<Purchase>, List<PurchaseDTO>>(list);
            }
        }

        public List<PurchaseDTO> GetAllPurchases()
        {
            List<Purchase> list = PurchaseDal.GetAllPurchases();
            return imapper.Map<List<Purchase>, List<PurchaseDTO>>(list);
        }

        public PurchaseDTO GetPurchaseByCode(int Code)
        {
            Purchase u = PurchaseDal.GetPurchaseByCode(Code);
            return imapper.Map<Purchase, PurchaseDTO>(u);
        }

        public List<PurchaseDTO> UpdatePurchase(int Code, PurchaseDTO Purchase)
        {
            try
            {
                Purchase u = imapper.Map<PurchaseDTO, Purchase>(Purchase);
                List<Purchase> list = PurchaseDal.UpdatePurchase(Code, u);
                return imapper.Map<List<Purchase>, List<PurchaseDTO>>(list);
            }
            catch
            {
                List<Purchase> list = PurchaseDal.GetAllPurchases();
                return imapper.Map<List<Purchase>, List<PurchaseDTO>>(list);
            }
        }
    }
}
