using API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> Get();

        Task<User> Get(Guid id);

        Task<User> GetByEmail(string email, Guid? id = null);

        Task<User> Post(User model);

        Task<User> Put(User model);

        Task Delete(Guid id);
    }
}
