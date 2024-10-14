using DataLayer.Models;
using DTOLayer;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;
using System.Collections.Generic;

namespace EmploymentSys.Controllers
{
    [ApiController]
    public class RoleController : Controller
    {
        private readonly ICustomServices<RoleDTO> _RoleService;
        public RoleController(ICustomServices<RoleDTO> roleService)
        {
            _RoleService = roleService;
        }


    }
}
