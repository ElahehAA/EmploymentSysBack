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
    public class UserReository : IUserRepository<User>
    {
        #region property
        private readonly EmploymentSysContext _employmentSysContext;
        private DbSet<User> entities;
        #endregion
        #region Constructor
        public UserReository(EmploymentSysContext employmentSysContext)
        {
            _employmentSysContext = employmentSysContext;
            entities = _employmentSysContext.Set<User>();
        }
        #endregion
        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return entities
                .Include(i=>i.Role)
                .AsEnumerable();
        }

        public void Insert(User entity)
        {
            _employmentSysContext.Add(entity);
            _employmentSysContext.SaveChanges();

        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
