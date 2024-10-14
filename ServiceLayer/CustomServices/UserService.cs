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
    public class UserService : ICustomServices<UserDTO>
    {

        private readonly IRepository<User> _UserRepository;
        public UserService(IRepository<User> userRepository)
        {
            _UserRepository = userRepository;
        }

        public void Delete(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public UserDTO Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetAllLis()
        {
            var s=_UserRepository.GetAll().ToList();
            var DTO = s.Select(a =>
            {
                UserDTO dto = new UserDTO();
                dto.Id = a.Id;
                dto.Name = a.Name;
                dto.Email = a.Email;
                dto.Address = a.Address;
                return dto;
            }).ToList();

            return DTO;
        }

        public void Insert(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(UserDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
