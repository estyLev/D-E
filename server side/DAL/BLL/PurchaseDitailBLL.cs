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
    
   public class PurchaseDitailBLL : IPurchaseDitailBLL
    {
        IPurchaseDitailDAL PurchaseDitailDal;
        IMapper imapper;

        public PurchaseDitailBLL(IPurchaseDitailDAL PurchaseDitailDal)
        {
            this.PurchaseDitailDal = PurchaseDitailDal;

            var config = new MapperConfiguration(cnf => cnf.AddProfile<AutoPurchaseDitail>());
            imapper = config.CreateMapper();
        }
        public List<PurchaseDitailDTO> AddPurchaseDitail(PurchaseDitailDTO PurchaseDitail)
        {
            try
            {
                PurchaseDitail u = imapper.Map<PurchaseDitailDTO, PurchaseDitail>(PurchaseDitail);
                List<PurchaseDitail> list = PurchaseDitailDal.AddPurchaseDitail(u);
                return imapper.Map<List<PurchaseDitail>, List<PurchaseDitailDTO>>(list);

            }
            catch
            {
                List<PurchaseDitail> list = PurchaseDitailDal.GetAllPurchaseDitails();
                return imapper.Map<List<PurchaseDitail>, List<PurchaseDitailDTO>>(list);
            }
        }

        public List<PurchaseDitailDTO> DeletePurchaseDitail(int Code)
        {
            try
            {
                List<PurchaseDitail> list = PurchaseDitailDal.DeletePurchaseDitail(Code);
                return imapper.Map<List<PurchaseDitail>, List<PurchaseDitailDTO>>(list);

            }
            catch
            {
                List<PurchaseDitail> list = PurchaseDitailDal.GetAllPurchaseDitails();
                return imapper.Map<List<PurchaseDitail>, List<PurchaseDitailDTO>>(list);
            }
        }

        public List<PurchaseDitailDTO> GetAllPurchaseDitails()
        {
            List<PurchaseDitail> list = PurchaseDitailDal.GetAllPurchaseDitails();
            return imapper.Map<List<PurchaseDitail>, List<PurchaseDitailDTO>>(list);
        }

        public PurchaseDitailDTO GetPurchaseDitailByCode(int Code)
        {
            PurchaseDitail u = PurchaseDitailDal.GetPurchaseDitailByCode(Code);
            return imapper.Map<PurchaseDitail, PurchaseDitailDTO>(u);
        }

        public List<PurchaseDitailDTO> UpdatePurchaseDitail(int Code, PurchaseDitailDTO PurchaseDitail)
        {
            try
            {
                PurchaseDitail u = imapper.Map<PurchaseDitailDTO, PurchaseDitail>(PurchaseDitail);
                List<PurchaseDitail> list = PurchaseDitailDal.UpdatePurchaseDitail(Code, u);
                return imapper.Map<List<PurchaseDitail>, List<PurchaseDitailDTO>>(list);
            }
            catch
            {
                List<PurchaseDitail> list = PurchaseDitailDal.GetAllPurchaseDitails();
                return imapper.Map<List<PurchaseDitail>, List<PurchaseDitailDTO>>(list);
            }
        }
    }
}
