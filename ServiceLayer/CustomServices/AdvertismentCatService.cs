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
    public class AdvertismentCatService : ICustomServices<AdvertismentCatDTO>
    {

        private readonly IRepository<AdvertismentCat> _AdvertismentCatRepository;
        public AdvertismentCatService(IRepository<AdvertismentCat> advertismentCatRepository)
        {
            _AdvertismentCatRepository = advertismentCatRepository;
        }

        public void Delete(AdvertismentCatDTO entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Insert(AdvertismentCatDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(AdvertismentCatDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AdvertismentCatDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
