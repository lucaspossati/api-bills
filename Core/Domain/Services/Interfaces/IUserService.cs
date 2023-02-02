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
        public Task<List<UserVM>> Get();
        public Task<UserVM> Get(Guid id);
        public Task<UserVM> Post(UserVM model);
        public Task<UserVM> Put(UserVM model);
        public Task<UserVM> Delete(Guid id);
    }
}
