using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class AdvertismentCatDTO:BaseDTO
    {
        public long? Id { get; set; }
        public string Name { get; set; } = null!;
        public long Code { get; set; }
    }
}
