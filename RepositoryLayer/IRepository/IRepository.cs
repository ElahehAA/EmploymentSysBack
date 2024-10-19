using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace RepositoryLayer.IRepository
{
    public interface IRepository <T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(long Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
