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
using RepositoryLayer.Repository;

namespace ServiceLayer.CustomServices
{
    public class UserService : ICustomUserServices<UserDTO>
    {

        private UserReository _UserRepository;
        private TokenService _TokenService;
        //private RoleService _RoleService;
        private ICustomServices<RoleDTO> _RoleService;
        public UserService(
            UserReository userRepository,
            TokenService tokenService,
            ICustomServices<RoleDTO> roleService)
        {
            _UserRepository = userRepository;
            _TokenService = tokenService;
            _RoleService = roleService;
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
                Password = user.Password,
                RoleType=user.Role.RoleType,
            };

            return dto;
        }
        public LoginDTO Login(UserDTO userDTO)
        {
            UserDTO? user = AuthenticateUser(userDTO);
            LoginDTO dTO = new LoginDTO();
            dTO.UserName = user.UserName;
            dTO.Password = user.Password;
            dTO.RoleType = user.RoleType.GetValueOrDefault(0);

            if (user != null) {
                dTO.token = _TokenService.GenerateToken(user);
            }
            else
            {
                dTO.token = "";
            }
            return dTO;
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
                dto.RoleType=a.Role.RoleType;
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

        public UserDTO? Register(UserDTO userDto)
        {
            bool IsExist=_UserRepository.GetAll().Any(i=>i.UserName == userDto.UserName);
            RoleDTO? role = _RoleService.GetAllList().FirstOrDefault(i => i.RoleType == 2);
            if (IsExist)
            {
                return null;
            }
            User user = new User()
            {
                UserName = userDto.UserName,
                Name = userDto.Name,
                Password = userDto.Password,
                Email = userDto.Email,
                PhoneNum = userDto.PhoneNum,
                Address = userDto.Address,
                RoleId = role.Id
            };
            _UserRepository.Insert(user);
            userDto.RoleType = role.RoleType;
            userDto.token = _TokenService.GenerateToken(userDto);
            return userDto;
        }

        UserDTO ICustomUserServices<UserDTO>.Insert(UserDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
