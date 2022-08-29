using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using System.Linq;

namespace DAL
{
    public class CategoryDAL : ICategoryDAL
    {
        FurnitursContext mydb;
        public CategoryDAL(FurnitursContext mydb)
        {
            this.mydb = mydb;
        }
        public List<Category> AddCategory(Category Category)
        {
            try
            {
                mydb.Categorys.Add(Category);
                mydb.SaveChanges();
                return mydb.Categorys.ToList();
            }
            catch
            {
                return mydb.Categorys.ToList();
            }
        }

        public List<Category> DeleteCategory(int Code)
        {
            try
            {
                Category temp = mydb.Categorys.FirstOrDefault(u => u.CategoryCode == Code);
                mydb.Categorys.Remove(temp);
                mydb.SaveChanges();
                return mydb.Categorys.ToList();
            }
            catch
            {
                return mydb.Categorys.ToList();
            }
        }

        public List<Category> GetAllCategorys()
        {
            return mydb.Categorys.ToList();
        }

        public Category GetCategoryByCode(int Code)
        {
            return mydb.Categorys.FirstOrDefault(u => u.CategoryCode == Code);
        }

        public List<Category> UpdateCategory(int Code, Category Category)
        {
            try
            {
                Category temp = mydb.Categorys.FirstOrDefault(u => u.CategoryCode == Code);
                mydb.Categorys.Remove(temp);
                mydb.Categorys.Add(Category);
                mydb.SaveChanges();
                return mydb.Categorys.ToList();
            }
            catch
            {
                return mydb.Categorys.ToList();
            }
        }
    }
}
