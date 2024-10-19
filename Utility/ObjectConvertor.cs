using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class ObjectConvertor
    {

        public static B ConvertObject<A,B>(A item)
        {
            var configuration = new MapperConfiguration(cong =>
            {
                cong.CreateMap<A, B>();
            });
            var mapper = configuration.CreateMapper();
            var DTO=mapper.Map<B>(item);
            return DTO;
        }
    }
}
