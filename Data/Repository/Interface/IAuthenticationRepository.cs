using API.Domain.Models;
using API.Domain.VM;
using Manager.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IAuthenticationRepository
    {
        Task<UserAuthenticated> Login(string email, string password);
    }
}
