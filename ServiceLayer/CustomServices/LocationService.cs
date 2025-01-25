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
    public class LocationService : ICustomServices<LocationDTO>
    {

        private readonly IRepository<Location> _LocationRepository;
        public LocationService(IRepository<Location> locationRepository)
        {
            _LocationRepository = locationRepository;
        }

        public void Delete(LocationDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public LocationDTO Get(long Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LocationDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<LocationDTO> GetAllLis()
        {
            throw new NotImplementedException();
        }

        public List<LocationDTO> GetAllList()
        {
            List<Location> locations= _LocationRepository.GetAll().Where(i=>i.Pid!=null).ToList();
            List<LocationDTO> DTOs = locations.Select(i =>
            {
                LocationDTO dto = ObjectConvertor.ConvertObject<Location, LocationDTO>(i);
                return dto;
            }).ToList();

            return DTOs;
        }

        public void Insert(LocationDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(LocationDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(LocationDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
