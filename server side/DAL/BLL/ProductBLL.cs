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
    public class ProductBLL : IProductBLL
    {
        IProductDAL ProductDal;
        IMapper imapper;

        public ProductBLL(IProductDAL ProductDal)
        {
            this.ProductDal = ProductDal;

            var config = new MapperConfiguration(cnf => cnf.AddProfile<AutoProduct>());
            imapper = config.CreateMapper();
        }
        public List<ProductDTO> AddProduct(ProductDTO Product)
        {
            try
            {
                Product u = imapper.Map<ProductDTO, Product>(Product);
                List<Product> list = ProductDal.AddProduct(u);
                return imapper.Map<List<Product>, List<ProductDTO>>(list);

            }
            catch
            {
                List<Product> list = ProductDal.GetAllProducts();
                return imapper.Map<List<Product>, List<ProductDTO>>(list);
            }
        }

        public List<ProductDTO> DeleteProduct(int Code)
        {
            try
            {
                List<Product> list = ProductDal.DeleteProduct(Code);
                return imapper.Map<List<Product>, List<ProductDTO>>(list);

            }
            catch
            {
                List<Product> list = ProductDal.GetAllProducts();
                return imapper.Map<List<Product>, List<ProductDTO>>(list);
            }
        }

        public List<ProductDTO> GetAllProducts()
        {
            List<Product> list = ProductDal.GetAllProducts();
            return imapper.Map<List<Product>, List<ProductDTO>>(list);
        }

        public ProductDTO GetProductByCode(int Code)
        {
            Product u = ProductDal.GetProductByCode(Code);
            return imapper.Map<Product, ProductDTO>(u);
        }

        public List<ProductDTO> UpdateProduct(int Code, ProductDTO Product)
        {
            try
            {
                Product u = imapper.Map<ProductDTO, Product>(Product);
                List<Product> list = ProductDal.UpdateProduct(Code, u);
                return imapper.Map<List<Product>, List<ProductDTO>>(list);
            }
            catch
            {
                List<Product> list = ProductDal.GetAllProducts();
                return imapper.Map<List<Product>, List<ProductDTO>>(list);
            }
        }
        public List<ProductDTO> GetProductListByCategory(int Code)
        {

            List<Product> list = ProductDal.GetProductListByCategory(Code);
            return imapper.Map<List<Product>, List<ProductDTO>>(list);
        }
    }
}
