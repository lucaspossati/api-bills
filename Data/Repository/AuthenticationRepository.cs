using API.Data;
using API.Domain.Models;
using API.Domain.VM;
using API.ValueObjects;
using BCrypt.Net;
using Data.Repository.Interface;
using Data.Services.Interface;
using Manager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly DataContext context;
        private readonly IJWTService jwtService;

        public AuthenticationRepository(DataContext context, IJWTService jwtService)
        {
            this.context = context;
            this.jwtService = jwtService;
        }

        public async Task<UserAuthenticated> Login(string email, string password)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Email == email);

            if (user == null) return null;

            bool verified = BCrypt.Net.BCrypt.Verify(password, user.Password);

            if (!verified) return null;

            var token = jwtService.GenerateToken(user);
            user.Password = "";

            return new UserAuthenticated
            {
                User = user,
                Token = token
            };
        }

    }
}
