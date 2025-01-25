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

        [HttpPost]
        [Route("EmploymentSys/Advertisment")]
        public ActionResult Insert(AdvertismentDTO advertismentDTO)
        {
            _AdvertismentService.Insert(advertismentDTO);
            return Ok();
        }

        [HttpPut]
        [Route("EmploymentSys/Advertisment")]
        public ActionResult Update(AdvertismentDTO advertismentDTO)
        {
            _AdvertismentService.Update(advertismentDTO);
            return Ok();
        }

        [HttpGet]
        [Route("EmploymentSys/Advertisment")]
        public ActionResult GetAllList()
        {
            var Result = _AdvertismentService.GetAllList();
            return Ok(Result);
        }

        [HttpGet]
        [Route("EmploymentSys/Advertisment/{ID}")]
        public ActionResult FindById(long ID)
        {
            var Result = _AdvertismentService.Get(ID);
            return Ok(Result);
        }

        [HttpDelete]
        [Route("EmploymentSys/Advertisment/{ID}")]
        public ActionResult Delete(long ID)
        {
            _AdvertismentService.Delete(ID);
            return Ok();
        }
    }
}
