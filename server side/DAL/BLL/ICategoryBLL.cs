using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL
{
    public interface ICategoryBLL
    {
        public List<CategoryDTO> GetAllCategorys();
        public CategoryDTO GetCategoryByCode(int Code);
        public List<CategoryDTO> AddCategory(CategoryDTO Category);
        public List<CategoryDTO> UpdateCategory(int Code, CategoryDTO Category);
        public List<CategoryDTO> DeleteCategory(int Code);
    }
}
