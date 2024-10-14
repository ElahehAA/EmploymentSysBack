using DataLayer.Models;
using DTOLayer;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;
using System.Collections.Generic;

namespace EmploymentSys.Controllers
{
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ICustomServices<LocationDTO> _LocationService;
        public LocationController(ICustomServices<LocationDTO> LocationService)
        {
            _LocationService = LocationService;
        }

    }
}
