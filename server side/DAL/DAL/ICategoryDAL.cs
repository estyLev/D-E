using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL
{
    public interface ICategoryDAL
    {
        public List<Category> GetAllCategorys();
        public Category GetCategoryByCode(int Code);
        public List<Category> AddCategory(Category Category);
        public List<Category> UpdateCategory(int Code, Category Category);
        public List<Category> DeleteCategory(int Code);
    }
}
