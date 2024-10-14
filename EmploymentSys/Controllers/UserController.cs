using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;
using System.Collections.Generic;

namespace EmploymentSys.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        private readonly ICustomServices<User> _UserService;
        public UserController(ICustomServices<User> userService)
        {
            _UserService = userService;
        }

        [HttpGet]
        [Route("User/GetAll")]
        public IActionResult GetAll()
        {
            var Result = _UserService.GetAllLis();
            return Ok(Result);
        }
    }
}
