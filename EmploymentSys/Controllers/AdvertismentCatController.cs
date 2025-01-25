using DataLayer.Models;
using DTOLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;
using System.Collections.Generic;
using System.Security.Claims;
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

        [HttpPost]
        [Route("EmploymentSys/AdvertismentCat")]
        public ActionResult Insert(AdvertismentCatDTO dto)
        {
            _AdvertismentCatService.Insert(dto);
            return Ok(dto);
        }

        [HttpPut]
        [Route("EmploymentSys/AdvertismentCat")]
        public ActionResult Update(AdvertismentCatDTO dto)
        {
            _AdvertismentCatService.Update(dto);
            return Ok(dto);
        }

        [HttpGet,Authorize]
        [Route("EmploymentSys/AdvertismentCat")]
        public ActionResult BindGridData()
        {
            List<AdvertismentCatDTO> result=_AdvertismentCatService.GetAllList();
            return Ok(result);
        }

        [HttpDelete]
        [Route("EmploymentSys/AdvertismentCat/{id}")]
        public ActionResult Delete(int id)
        { 
            _AdvertismentCatService.Delete(id);
            return Ok();
        }
    }
}
