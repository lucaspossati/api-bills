using API.Domain.Models;
using API.Domain.VM;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IAuthenticationRepository
    {
        Task<UserAuthenticatedVM> Login(string email, string password);
    }
}
