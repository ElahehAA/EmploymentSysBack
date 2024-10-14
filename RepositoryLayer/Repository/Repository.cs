using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;


namespace RepositoryLayer.Repository
{
        public class Repository<T> : IRepository<T> where T : class
        {
            #region property
            private readonly EmploymentSysContext _employmentSysContext;
            private DbSet<T> entities;
            #endregion
            #region Constructor
            public Repository(EmploymentSysContext employmentSysContext)
            {
                _employmentSysContext = employmentSysContext;
                entities = _employmentSysContext.Set<T>();
            }

            public void Delete(T entity)
            {
                if (entities == null)
                {
                    throw new NotImplementedException();
                }
                entities.Remove(entity);
                _employmentSysContext.SaveChanges();
            }

            public T Get(int Id)
            {
                return entities.Find(Id);
            }

            public IEnumerable<T> GetAll()
            {
                return entities.AsEnumerable();
            }

            public void Insert(T entity)
            {
                if (entities == null)
                {
                    throw new NotImplementedException();
                }
                entities.Add(entity);
                _employmentSysContext.SaveChanges();

            }

            public void Remove(T entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                entities.Remove(entity);
            }

            public void SaveChanges()
            {
                _employmentSysContext.SaveChanges();
            }

            public void Update(T entity)
            {
                if(entities == null)
                {
                    throw new ArgumentNullException("entity");
                }
                entities.Update(entity);
                _employmentSysContext.SaveChanges();
            }
            #endregion
        }
}
