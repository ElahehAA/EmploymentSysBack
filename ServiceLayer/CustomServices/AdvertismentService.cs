using DataLayer.Models;
using DTOLayer;
using RepositoryLayer.IRepository;
using RepositoryLayer.Repository;
using ServiceLayer.ICustomServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ServiceLayer.CustomServices
{
    public class AdvertismentService : ICustomServices<AdvertismentDTO>
    {

        private readonly AdvertismentRepository _AdvertismentRepository;
        public AdvertismentService(AdvertismentRepository advertismentRepository)
        {
            _AdvertismentRepository = advertismentRepository;
        }

        public void Delete(AdvertismentDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {

            Advertisment advertisment = _AdvertismentRepository.Get(id);
            _AdvertismentRepository.Delete(advertisment);
            return;
        }

        public AdvertismentDTO Get(long Id)
        {
            Advertisment advertisment=_AdvertismentRepository.Get(Id);
            if (advertisment == null) {
                throw new Exception("موردی یافت نشد");
            }
            AdvertismentDTO dTO = ObjectConvertor.ConvertObject<Advertisment, AdvertismentDTO>(advertisment);
            return dTO;
        }

        public IEnumerable<AdvertismentDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AdvertismentDTO> GetAllList()
        {
            List<Advertisment> advertisments = _AdvertismentRepository.GetAll().ToList();
            List<AdvertismentDTO> DTOs= advertisments.Select(a =>
            {
                AdvertismentDTO dto = ObjectConvertor.ConvertObject<Advertisment, AdvertismentDTO>(a);
                dto.AdvertismentCatname = a.AdvertismentCat.Name;
                dto.CityName = a.City.Name;
                return dto;
            }).ToList();
            return DTOs;
        }

        public void Insert(AdvertismentDTO entity)
        {
            Advertisment advertisment=ObjectConvertor.ConvertObject<AdvertismentDTO,Advertisment>(entity);
            _AdvertismentRepository.Insert(advertisment);
            return;
        }

        public void Remove(AdvertismentDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AdvertismentDTO entity)
        {
            Advertisment? advertisment=_AdvertismentRepository.GetAll().FirstOrDefault(i=>i.Id==entity.Id);
            if (advertisment == null)
            {
                throw new Exception("موردی یافت نشد");
            }
            advertisment.JobName=entity.JobName;
            advertisment.AdvertismentCatId=entity.AdvertismentCatId;
            advertisment.CityId=entity.CityId;
            advertisment.Desc=entity.Desc;
            advertisment.MilitaryStatus=entity.MilitaryStatus;
            advertisment.MinHistory=entity.MinHistory;
            advertisment.Rights=entity.Rights;
            advertisment.Gender=entity.Gender;

            _AdvertismentRepository.Update(advertisment);
            return;
        }
    }
}
