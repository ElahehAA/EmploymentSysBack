using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Extension
{
    public class AuthService
    {
        private IHttpContextAccessor _http;
        public AuthService(IHttpContextAccessor http)
        {
            _http = http;
        }
        public long GetUserID()
        {
            var userID = _http.HttpContext.User.Claims.FirstOrDefault(i=>i.Type== "User").Value;
            return Convert.ToInt64(userID);
        }

    }
}
