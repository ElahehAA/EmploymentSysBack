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
    public class RoleService : ICustomServices<RoleDTO>
    {

        private readonly IRepository<Role> _RoleRepository;
        public RoleService(IRepository<Role> roleRepository)
        {
            _RoleRepository = roleRepository;
        }

        public void Delete(RoleDTO entity)
        {
            throw new NotImplementedException();
        }

        public RoleDTO Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoleDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<RoleDTO> GetAllLis()
        {
            throw new NotImplementedException();
        }

        public List<RoleDTO> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void Insert(RoleDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(RoleDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(RoleDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
