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
        public ActionResult Login(UserDTO userDTO)
        {
            try
            {
                LoginDTO Result=_UserService.Login(userDTO);
                if (!string.IsNullOrEmpty(Result.token)) { 
                    return Ok(Result);
                }
                return BadRequest("نام کاربری یا رمز عبور وارد شده اشتباه می باشد");
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("EmploymentSys/Register")]
        public ActionResult Register(UserDTO userDTO) { 
            UserDTO Result=_UserService.Register(userDTO);
            if (Result == null)
            {
                return BadRequest("این نام کاربری قبلا ثبت نام کرده است");
            }
            return Ok(Result);
        }

    }
}
