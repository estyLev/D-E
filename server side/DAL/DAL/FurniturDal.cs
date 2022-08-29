using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Models;

namespace DAL
{
    public class UsersDal : IUsersDal
    {
        FurnitursContext mydb;
        public UsersDal(FurnitursContext mydb)
        {
            this.mydb = mydb;
        }
        public List<User> AddUser(User user)
        {
            try
            {
                mydb.Users.Add(user);
                mydb.SaveChanges();
                return mydb.Users.ToList();;
            }
            catch
            {
                return mydb.Users.ToList();
            }
        }

        public List<User> DeleteUser(int Code)
        {
            try
            {
                User temp = mydb.Users.FirstOrDefault(u => u.UserCode == Code);
                mydb.Users.Remove(temp);
                mydb.SaveChanges();
                return mydb.Users.ToList();;
            }
            catch
            {
                return mydb.Users.ToList();
            }
        }

        public List<User> GetAllUsers()
        {
            return mydb.Users.ToList();
        }

        public User GetUserByCode(int Code)
        {
            return mydb.Users.FirstOrDefault(u => u.UserCode == Code);
        }

        public List<User> UpdateUser(int Code, User user)
        {
            try
            {
                User temp = mydb.Users.FirstOrDefault(u => u.UserCode == Code);
                mydb.Users.Remove(temp);
                mydb.Users.Add(user);
                mydb.SaveChanges();
                return mydb.Users.ToList();
            }
            catch
            {
                return mydb.Users.ToList();
            }
        }
    }
}
