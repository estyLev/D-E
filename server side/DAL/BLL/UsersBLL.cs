using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using DAL.Models;
using AutoMapper;



namespace BLL
{
    
       public class UserBLL : IUsersBLL
    {
        IUsersDal UserDal;
        IMapper imapper;

        public UserBLL(IUsersDal UserDal)
        {
            this.UserDal = UserDal;

            var config = new MapperConfiguration(cnf => cnf.AddProfile<AutoUser>());
            imapper = config.CreateMapper();
        }
        public List<UserDTO> AddUser(UserDTO User)
        {
            try
            {
                User u = imapper.Map<UserDTO, User>(User);
                List<User> list = UserDal.AddUser(u);
                return imapper.Map<List<User>, List<UserDTO>>(list);

            }
            catch
            {
                List<User> list = UserDal.GetAllUsers();
                return imapper.Map<List<User>, List<UserDTO>>(list);
            }
        }

        public List<UserDTO> DeleteUser(int Code)
        {
            try
            {
                List<User> list = UserDal.DeleteUser(Code);
                return imapper.Map<List<User>, List<UserDTO>>(list);

            }
            catch
            {
                List<User> list = UserDal.GetAllUsers();
                return imapper.Map<List<User>, List<UserDTO>>(list);
            }
        }

        public List<UserDTO> GetAllUsers()
        {
            List<User> list = UserDal.GetAllUsers();
            return imapper.Map<List<User>, List<UserDTO>>(list);
        }

        public UserDTO GetUserByCode(int Code)
        {
            User u = UserDal.GetUserByCode(Code);
            return imapper.Map<User, UserDTO>(u);
        }

        public List<UserDTO> UpdateUser(int Code, UserDTO User)
        {
            try
            {
                User u = imapper.Map<UserDTO, User>(User);
                List<User> list = UserDal.UpdateUser(Code, u);
                return imapper.Map<List<User>, List<UserDTO>>(list);
            }
            catch
            {
                List<User> list = UserDal.GetAllUsers();
                return imapper.Map<List<User>, List<UserDTO>>(list);
            }
        }
    }
}
