using DataLayer.Models;
using DTOLayer;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.CustomServices;
using ServiceLayer.ICustomServices;
using System.Collections.Generic;

namespace EmploymentSys.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        private readonly ICustomUserServices<UserDTO> _UserService;
        public UserController(ICustomUserServices<UserDTO> userService)
        {
            _UserService = userService;
        }


        [HttpPost]
        [Route("EmploymentSys/Login")]
        public ActionResult Login([FromBody]UserDTO userDTO)
        {
            string token=_UserService.Login(userDTO);
            if (!string.IsNullOrEmpty(token)) { 
                return Ok(token);
            }
            return BadRequest("نام کاربری یا رمز عبور وارد شده اشتباه می باشد");
        }

        [HttpGet]
        [Route("EmploymentSys/GetAll")]
        public ActionResult GetAll()
        {
            var users = _UserService.GetAllList();
            return Ok(users);
        }
    }
}
