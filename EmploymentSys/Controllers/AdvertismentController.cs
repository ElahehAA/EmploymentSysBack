using DataLayer.Models;
using DTOLayer;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;
using System.Collections.Generic;

namespace EmploymentSys.Controllers
{
    [ApiController]
    public class AdvertismentController : Controller
    {
        private readonly ICustomServices<AdvertismentDTO> _AdvertismentService;
        public AdvertismentController(ICustomServices<AdvertismentDTO> AdvertismentService)
        {
            _AdvertismentService = AdvertismentService;
        }

    }
}
