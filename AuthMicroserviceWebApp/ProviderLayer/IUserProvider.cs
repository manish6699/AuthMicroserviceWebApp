using AuthMicroserviceWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthMicroserviceWebApp.ProviderLayer
{
    public interface IUserProvider
    {
        public string LoginProvider(UserDetails user);
        public string GenerateJSONWebToken(UserDetails userInfo);
        public int GetUserId(UserDetails user);
    }
}
