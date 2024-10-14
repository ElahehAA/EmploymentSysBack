using DataLayer.Models;
using DTOLayer;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;
using System.Collections.Generic;

namespace EmploymentSys.Controllers
{
    [ApiController]
    public class AdvertismentCatController : Controller
    {
        private readonly ICustomServices<AdvertismentCatDTO> _AdvertismentCatService;
        public AdvertismentCatController(ICustomServices<AdvertismentCatDTO> AdvertismentCatService)
        {
            _AdvertismentCatService = AdvertismentCatService;
        }

    }
}
