using DataLayer.Models;
using DTOLayer;
using RepositoryLayer.IRepository;
using ServiceLayer.Extension;
using ServiceLayer.ICustomServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Extension;

namespace ServiceLayer.CustomServices
{
    public class UserService : ICustomUserServices<UserDTO>
    {

        private readonly IRepository<User> _UserRepository;
        private TokenService _TokenService;
        public UserService(
            IRepository<User> userRepository, TokenService tokenService)
        {
            _UserRepository = userRepository;
            _TokenService = tokenService;
        }

        public UserDTO? AuthenticateUser(UserDTO userDTO)
        {
            User user = _UserRepository.GetAll().FirstOrDefault(i => i.UserName == userDTO.UserName && i.Password == userDTO.Password);
            if (user == null)
            {
                return null;
            }
            UserDTO dto = new UserDTO()
            {
                UserName = user.UserName,
                Password = user.Password
            };

            return dto;
        }
        public string Login(UserDTO userDTO)
        {
           UserDTO? user = AuthenticateUser(userDTO);
            if (user != null) {
                string token = _TokenService.GenerateToken(user);
                return token;
            }
            return "";
        }
        public void Delete(UserDTO userDTO)
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

        public List<UserDTO> GetAllList()
        {
            List<User> users = _UserRepository.GetAll().ToList();
            List<UserDTO> DTOs = users.Select(a =>
            {
                UserDTO dto = new UserDTO();
                dto.UserName = a.UserName;
                dto.RoleName = a.Role.Name;
                return dto;
            }).ToList();

            return DTOs;
        }

        public void Insert(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public void Remove(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public void Update(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
