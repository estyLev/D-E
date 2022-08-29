using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using System.Linq;

namespace DAL
{
    public class ProductDAL:IProductDAL
    {
        FurnitursContext mydb;
        public ProductDAL(FurnitursContext mydb)
        {
            this.mydb = mydb;
        }
        public List<Product> AddProduct(Product Product)
        {
            try
            {
                mydb.Products.Add(Product);
                mydb.SaveChanges();
                return mydb.Products.ToList();
            }
            catch
            {
                return mydb.Products.ToList();
            }
        }

        public List<Product> DeleteProduct(int Code)
        {
            try
            {
                Product temp = mydb.Products.FirstOrDefault(u => u.ProductCode == Code);
                mydb.Products.Remove(temp);
                mydb.SaveChanges();
                return mydb.Products.ToList();
            }
            catch
            {
                return mydb.Products.ToList();
            }
        }

        public List<Product> GetAllProducts()
        {
            return mydb.Products.ToList();
        }

        public Product GetProductByCode(int Code)
        {
            return mydb.Products.FirstOrDefault(u => u.ProductCode == Code);
        }

       
        public List<Product> UpdateProduct(int Code, Product Product)
        {
            try
            {
                Product temp = mydb.Products.FirstOrDefault(u => u.ProductCode == Code);
                mydb.Products.Remove(temp);
                mydb.Products.Add(Product);
                mydb.SaveChanges();
                return mydb.Products.ToList();
            }
            catch
            {
                return mydb.Products.ToList();
            }
        }
        public List<Product> GetProductListByCategory(int Code)
        {

            return mydb.Products.Where(p => p.CategoryCode == Code).ToList();
        }
    }
}
