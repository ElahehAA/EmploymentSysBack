using DataLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.ICustomServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CustomServices
{
    public class UserService : ICustomServices<User>
    {

        private readonly IRepository<User> _UserRepository;
        public UserService(IRepository<User> userRepository)
        {
            _UserRepository = userRepository;
        }
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
            return _UserRepository.GetAll();
        }

        public List<User> GetAllLis()
        {
            return _UserRepository.GetAll().ToList();

        }

        public void Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
