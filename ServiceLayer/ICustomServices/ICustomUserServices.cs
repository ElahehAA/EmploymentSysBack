using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ICustomServices
{
    public interface ICustomUserServices<DTO> where DTO : class
    {
        IEnumerable<DTO> GetAll();
        List<DTO> GetAllList();
        DTO Get(int Id);
        DTO Insert(DTO entity);
        void Update(DTO entity);
        void Delete(DTO entity);
        void Remove(DTO entity);
        DTO? AuthenticateUser(DTO entity);
        LoginDTO Login(DTO entity);
        UserDTO Register(DTO entity);

    }
}
