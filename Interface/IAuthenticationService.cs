using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Interface
{
    public interface IAuthenticationService
    {
        Task<string> Authenticate(string username, string password);
    }
}

