using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class UserDTO:BaseDTO
    {
        public long? Id { get; set; }
        public string Name { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string? PhoneNum { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string RoleName { get; set; }
        public string Password { get; set; }
        public int? RoleType { get; set; }
        public string token { get; set; }

    }

 
}
