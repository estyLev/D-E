using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using DAL;
using DTO;
using AutoMapper;

namespace BLL
{
   public class CategoryBLL:ICategoryBLL
    {
        ICategoryDAL CategoryDal;
        IMapper imapper;

        public CategoryBLL(ICategoryDAL CategoryDal)
        {
            this.CategoryDal = CategoryDal;

            var config = new MapperConfiguration(cnf => cnf.AddProfile<AutoCategory>());
            imapper = config.CreateMapper();
        }
        public List<CategoryDTO> AddCategory(CategoryDTO Category)
        {
            try
            {
                Category u = imapper.Map<CategoryDTO, Category>(Category);
                List<Category> list = CategoryDal.AddCategory(u);
                return imapper.Map<List<Category>, List<CategoryDTO>>(list);
                
            }
            catch
            {
                List<Category> list = CategoryDal.GetAllCategorys();
                return imapper.Map<List<Category>, List<CategoryDTO>>(list);
            }
        }

        public List<CategoryDTO> DeleteCategory(int Code)
        {
            try
            {
                List<Category> list = CategoryDal.DeleteCategory(Code);
                return imapper.Map<List<Category>, List<CategoryDTO>>(list);
                
            }
            catch
            {
                List<Category> list = CategoryDal.GetAllCategorys();
                return imapper.Map<List<Category>, List<CategoryDTO>>(list);
            }
        }

        public List<CategoryDTO> GetAllCategorys()
        {
            List<Category> list = CategoryDal.GetAllCategorys();
            return imapper.Map<List<Category>, List<CategoryDTO>>(list);
        }

        public CategoryDTO GetCategoryByCode(int Code)
        {
            Category u = CategoryDal.GetCategoryByCode(Code);
            return imapper.Map<Category, CategoryDTO>(u);
        }

        public List<CategoryDTO> UpdateCategory(int Code, CategoryDTO Category)
        {
            try
            {
                Category u = imapper.Map<CategoryDTO, Category>(Category);
                List<Category> list= CategoryDal.UpdateCategory(Code, u);
                return imapper.Map<List<Category>, List<CategoryDTO>>(list);
            }
            catch
            {
                List<Category> list = CategoryDal.GetAllCategorys();
                return imapper.Map<List<Category>, List<CategoryDTO>>(list);
            }
        }
    }
}
