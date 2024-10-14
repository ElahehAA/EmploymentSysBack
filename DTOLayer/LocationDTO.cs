using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class LocationDTO:BaseDTO
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Name { get; set; } = null!;
    }
}
