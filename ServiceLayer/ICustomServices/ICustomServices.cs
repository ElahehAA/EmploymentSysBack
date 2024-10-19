using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ICustomServices
{
    public interface ICustomServices <DTO> where DTO : BaseDTO
    {
        IEnumerable<DTO> GetAll();
        List<DTO> GetAllList();
        DTO Get(int Id);
        void Insert(DTO entity);
        void Update(DTO entity);
        void Delete(int id);
        void Remove(DTO entity);
    }
}
