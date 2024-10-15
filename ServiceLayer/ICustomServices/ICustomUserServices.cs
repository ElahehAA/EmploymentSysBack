using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ICustomServices
{
    public interface ICustomUserServices<DTO> where DTO : UserDTO
    {
        IEnumerable<DTO> GetAll();
        List<DTO> GetAllList();
        DTO Get(int Id);
        void Insert(DTO entity);
        void Update(DTO entity);
        void Delete(DTO entity);
        void Remove(DTO entity);
        DTO? AuthenticateUser(DTO entity);
        string Login(DTO entity);
    }
}
