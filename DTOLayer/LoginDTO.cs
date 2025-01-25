﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class LoginDTO
    {
        public long? Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; }
        public string token { get; set; }
        public int RoleType { get; set; }

    }
}
