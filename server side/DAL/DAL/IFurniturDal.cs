using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL
{
    public interface IUsersDal
    {
        public List<User> GetAllUsers();
        public User GetUserByCode(int Code);
        public List<User> AddUser(User user);
        public List<User> UpdateUser(int Code,User user);
        public List<User> DeleteUser(int Code);
    }
}
