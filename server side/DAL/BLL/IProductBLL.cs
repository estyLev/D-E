using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL
{
    public interface IProductBLL
    {
        public List<ProductDTO> GetAllProducts();
        public ProductDTO GetProductByCode(int Code);
        public List<ProductDTO> AddProduct(ProductDTO Product);
        public List<ProductDTO> UpdateProduct(int Code, ProductDTO Product);
        public List<ProductDTO> DeleteProduct(int Code);
        public List<ProductDTO> GetProductListByCategory(int Code);
        
    }
}
