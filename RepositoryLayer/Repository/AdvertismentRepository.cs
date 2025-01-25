using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class AdvertismentRepository : IAdvertismentRepository<Advertisment>
    {
        #region property
        private readonly EmploymentSysContext _employmentSysContext;
        private DbSet<Advertisment> entities;
        #endregion
        #region Constructor
        public AdvertismentRepository(EmploymentSysContext employmentSysContext)
        {
            _employmentSysContext = employmentSysContext;
            entities = _employmentSysContext.Set<Advertisment>();
        }
        #endregion
        public void Delete(Advertisment entity)
        {
            entities.Remove(entity);
            _employmentSysContext.SaveChanges();
        }

        public Advertisment Get(long Id)
        {
            return entities.FirstOrDefault(i => i.Id == Id);
        }

        public IEnumerable<Advertisment> GetAll()
        {
            return entities.Include(i=>i.City)
                .Include(i=>i.AdvertismentCat)
                .AsEnumerable(); 
        }

        public void Insert(Advertisment entity)
        {
            if (entity == null)
            {
                throw new NotImplementedException();
            }
            entities.Add(entity);
            _employmentSysContext.SaveChanges();
        }

        public void Remove(Advertisment entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Advertisment entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            _employmentSysContext.SaveChanges();
        }
    }
}
