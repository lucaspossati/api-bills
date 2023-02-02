

using api.Domain.Services.Interfaces;
using API.Domain.Models;
using API.Domain.VM;
using AutoMapper;
using Core.Validator;
using Data.Repository.Interface;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace api.Domain.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IMapper mapper;
        private readonly IAuthenticationRepository authenticationRepository;

        public AuthenticationService(IMapper mapper, IAuthenticationRepository authenticationRepository)
        {
            this.mapper = mapper;
            this.authenticationRepository = authenticationRepository;
        }

        public async Task<UserAuthenticatedVM> Login(string email, string password)
        {
            return await authenticationRepository.Login(email, password);
        }
    }
}
