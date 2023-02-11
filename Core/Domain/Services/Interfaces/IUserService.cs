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
    public interface IUserService
    {
        Task<List<UserVM>> Get();
        Task<UserVM> Get(Guid id);
        Task<UserVM> GetByEmail(string email);
        Task<UserVM> Post(UserVM model);
        Task<UserVM> Put(UserVM model);
        Task<UserVM> Delete(Guid id);
        Task<UserAuthenticatedVM> CreateAndAuthenticate(UserVM model);
    }
}
