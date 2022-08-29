using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;
using DTO;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductController : ControllerBase
    {
        IProductBLL ProductsBLL;
        public ProductController(IProductBLL _ProductsBLL)
        {
            ProductsBLL = _ProductsBLL;
        }

        [HttpGet("GetAllProducts")]
        public ActionResult GetAllProducts()
        {
            return Ok(ProductsBLL.GetAllProducts());
        }

        [HttpGet("GetProductByCode/{Code}")]
        public ActionResult GetProductByCode(int Code)
        {
            return Ok(ProductsBLL.GetProductByCode(Code));
        }
        [HttpGet("GetProductListByCategory/{Code}")]
        public ActionResult GetProductListByCategory(int Code)
        {
            return Ok(ProductsBLL.GetProductListByCategory(Code));
        }
        [HttpPost("AddProduct")]
        public ActionResult AddProduct(ProductDTO Product)
        {
            return Ok(ProductsBLL.AddProduct(Product));
        }

        [HttpPut("UpdateProduct/{Code}")]
        public ActionResult UpdateProduct(int Code, ProductDTO Product)
        {
            return Ok(ProductsBLL.UpdateProduct(Code, Product));
        }


        [HttpDelete("DeleteProduct/{Code}")]
        public ActionResult DeleteProduct(int Code)
        {
            return Ok(ProductsBLL.DeleteProduct(Code));
        }

    }
}