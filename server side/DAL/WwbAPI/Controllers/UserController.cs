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
    public class UserController : ControllerBase
    {
        IUsersBLL UsersBLL;
        public UserController(IUsersBLL _UsersBLL)
        {
            UsersBLL = _UsersBLL;
        }

        [HttpGet("GetAllUsers")]
        public ActionResult GetAllUsers()
        {
            return Ok(UsersBLL.GetAllUsers());
        }

        [HttpGet("GetUserByCode/{Code}")]
        public ActionResult GetUserByCode(int Code)
        {
            return Ok(UsersBLL.GetUserByCode(Code));
        }

        [HttpPost("AddUser")]
        public ActionResult AddUser(UserDTO user)
        {
            return Ok(UsersBLL.AddUser(user));
        }

        [HttpPut("UpdateUser/{Code}")]
        public ActionResult UpdateUser(int Code, UserDTO user)
        {
            return Ok(UsersBLL.UpdateUser(Code, user));
        }


        [HttpDelete("DeleteUser/{Code}")]
        public ActionResult DeleteUser(int Code)
        {
            return Ok(UsersBLL.DeleteUser(Code));
        }
    }
}