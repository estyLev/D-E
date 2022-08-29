using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DTO
{
    public class AutoUser : AutoMapper.Profile
    {
        public AutoUser()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
