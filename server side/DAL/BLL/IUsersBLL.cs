using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using DTO;

namespace BLL
{
    public interface IUsersBLL
    {
        public List<UserDTO> GetAllUsers();
        public UserDTO GetUserByCode(int Code);
        public List<UserDTO> AddUser(UserDTO user);
        public List<UserDTO> UpdateUser(int Code, UserDTO user);
        public List<UserDTO> DeleteUser(int Code);
    }
}
