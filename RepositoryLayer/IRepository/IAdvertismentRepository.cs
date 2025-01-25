using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace RepositoryLayer.IRepository
{
    public interface IAdvertismentRepository<Advertisment>
    {
        IEnumerable<Advertisment> GetAll();
        Advertisment Get(long Id);
        void Insert(Advertisment entity);
        void Update(Advertisment entity);
        void Delete(Advertisment entity);
        void Remove(Advertisment entity);
        void SaveChanges();
    }
}
