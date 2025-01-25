using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace RepositoryLayer.IRepository
{
    public interface IUserRepository<User>
    {
        IEnumerable<User> GetAll();
        User Get(int Id);
        User Insert(User entity);
        void Update(User entity);
        void Delete(User entity);
        void Remove(User entity);
        void SaveChanges();
    }
}
