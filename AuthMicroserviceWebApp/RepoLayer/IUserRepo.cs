using AuthMicroserviceWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthMicroserviceWebApp.RepoLayer
{
    public interface IUserRepo
    {
        UserDetails GetUserDetails(UserDetails user);
    }
}
