using api.Domain.VM.Shared;
using API.Domain.Models;
using API.Domain.VM;
using API.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Domain.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<UserAuthenticatedVM> Login(string email, string password);
    }
}
