using DataLayer.Models;
using DTOLayer;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;
using System.Collections.Generic;

namespace EmploymentSys.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        private readonly ICustomServices<UserDTO> _UserService;
        public UserController(ICustomServices<UserDTO> userService)
        {
            _UserService = userService;
        }

        [HttpGet]
        [Route("User/GetAll")]
        public IActionResult GetAll()
        {
            List<UserDTO> Result =_UserService.GetAllLis();
            return Ok(Result);
        }
    }
}
