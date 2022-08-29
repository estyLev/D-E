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
    public class CategoryController : ControllerBase
    {
        ICategoryBLL CategorysBLL;
        public CategoryController(ICategoryBLL _CategorysBLL)
        {
            CategorysBLL = _CategorysBLL;
        }

        [HttpGet("GetAllCategorys")]
        public ActionResult GetAllCategorys()
        {
            return Ok(CategorysBLL.GetAllCategorys());
        }

        [HttpGet("GetCategoryByCode/{Code}")]
        public ActionResult GetCategoryByCode(int Code)
        {
            return Ok(CategorysBLL.GetCategoryByCode(Code));
        }

        [HttpPost("AddCategory")]
        public ActionResult AddCategory(CategoryDTO Category)
        {
            return Ok(CategorysBLL.AddCategory(Category));
        }

        [HttpPut("UpdateCategory/{Code}")]
        public ActionResult UpdateCategory(int Code, CategoryDTO Category)
        {
            return Ok(CategorysBLL.UpdateCategory(Code, Category));
        }


        [HttpDelete("DeleteCategory/{Code}")]
        public ActionResult DeleteCategory(int Code)
        {
            return Ok(CategorysBLL.DeleteCategory(Code));
        }
    }
}