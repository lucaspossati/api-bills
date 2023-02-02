using API.Data;
using API.Domain.Models;
using API.ValueObjects;
using Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;

        public UserRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<User>> Get()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> Get(Guid id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<User> GetByEmail(string email, Guid? id = null)
        {
            if(id == null) return await context.Users.FirstOrDefaultAsync(x => x.Email == email);

            return await context.Users.FirstOrDefaultAsync(x => x.Email == email && x.Id != id);
        }

        public async Task<User> Post(User model)
        {
            context.Users.Add(model);

            await context.SaveChangesAsync();

            return model;
        }

        public async Task<User> Put(User model)
        {
            context.Entry(model).State = EntityState.Modified;

            await context.SaveChangesAsync();

            return model;
        }

        public async Task Delete(Guid id)
        {
            var user = await context.Users.FindAsync(id);

            context.Users.Remove(user);

            await context.SaveChangesAsync();
        }
    }
}
