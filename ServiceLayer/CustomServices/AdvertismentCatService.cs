using DataLayer.Models;
using DTOLayer;
using RepositoryLayer.IRepository;
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
    public class AdvertismentCatService : ICustomServices<AdvertismentCatDTO>
    {

        private readonly IRepository<AdvertismentCat> _AdvertismentCatRepository;
        public AdvertismentCatService(IRepository<AdvertismentCat> advertismentCatRepository)
        {
            _AdvertismentCatRepository = advertismentCatRepository;
        }


        public void Delete(int id)
        {
            AdvertismentCat cat=_AdvertismentCatRepository.Get(id);
            if (cat == null)
            {
                throw new Exception("موردی یافت نشد");
            }
            cat.IsDelete = true;
            _AdvertismentCatRepository.Update(cat);
            return;

        }

        public AdvertismentCatDTO Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdvertismentCatDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AdvertismentCatDTO> GetAllList()
        {
            IEnumerable<AdvertismentCat> cats = _AdvertismentCatRepository.GetAll().Where(i=>i.IsDelete==false);
            List<AdvertismentCatDTO> DTOs = cats.Select(a =>
            {
                AdvertismentCatDTO dto = new AdvertismentCatDTO();
                dto.Name = a.Name;
                dto.Code = a.Code;
                dto.Id = a.Id;
                return dto;
            }).ToList();

            return DTOs;
        }

        public void Insert(AdvertismentCatDTO catDTO)
        {
            AdvertismentCat cat=new AdvertismentCat();
            cat.Name= catDTO.Name;
            cat.Code= catDTO.Code;
            _AdvertismentCatRepository.Insert(cat);
            return;
        }

        public void Remove(AdvertismentCatDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AdvertismentCatDTO catDTO)
        {
            AdvertismentCat? cat = _AdvertismentCatRepository.GetAll().FirstOrDefault(i=>i.Id==catDTO.Id);
            if (cat == null)
            {
               throw new Exception("موردی یافت نشد");
            }
            cat.Name = catDTO.Name;
            cat.Code = catDTO.Code;
            _AdvertismentCatRepository.Update(cat);
            return;
        }
    }
}
