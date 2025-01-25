using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ICustomServices
{
    public interface ICustomServices <DTO> where DTO : class
    {
        IEnumerable<DTO> GetAll();
        List<DTO> GetAllList();
        DTO Get(long Id);
        void Insert(DTO entity);
        void Update(DTO entity);
        void Delete(long id);
        void Remove(DTO entity);
    }
}
