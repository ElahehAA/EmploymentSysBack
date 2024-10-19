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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public LocationDTO Get(int Id)
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
            throw new NotImplementedException();
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
