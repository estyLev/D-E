using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL
{
    public interface IProductDAL
    {
        public List<Product> GetAllProducts();
        public Product GetProductByCode(int Code);
        public List<Product> AddProduct(Product Product);
        public List<Product> UpdateProduct(int Code, Product Product);
        public List<Product> DeleteProduct(int Code);
        public List<Product> GetProductListByCategory(int Code);
    }
}
