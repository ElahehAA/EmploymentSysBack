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
    public class AdvertismentService : ICustomServices<AdvertismentDTO>
    {

        private readonly IRepository<Advertisment> _AdvertismentRepository;
        public AdvertismentService(IRepository<Advertisment> advertismentRepository)
        {
            _AdvertismentRepository = advertismentRepository;
        }

        public void Delete(AdvertismentDTO entity)
        {
            throw new NotImplementedException();
        }

        public AdvertismentDTO Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdvertismentDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AdvertismentDTO> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void Insert(AdvertismentDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(AdvertismentDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AdvertismentDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
