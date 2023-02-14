

using api.Domain.Services.Interfaces;
using api.Domain.VM.Shared;
using API.Domain.Models;
using API.Domain.VM;
using Application.Models;
using Application.VM;
using AutoMapper;
using Core.Validator;
using Core.Validator.User;
using Data.Repository;
using Data.Repository.Interface;
using FluentValidation.Results;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace api.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;
        private readonly ISpentInMonthRepository spentInMonthRepository;
        private readonly IMonthRepository monthRepository;
        private readonly IAuthenticationRepository authRepository;
        private readonly IEmailService emailService;

        public UserService(
            IMapper mapper,
            IUserRepository userRepository,
            IMonthRepository monthRepository,
            ISpentInMonthRepository spentInMonthRepository,
            IEmailService emailService,
            IAuthenticationRepository authRepository)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
            this.spentInMonthRepository = spentInMonthRepository;
            this.monthRepository = monthRepository;
            this.authRepository = authRepository;
            this.emailService = emailService;
        }

        public async Task<List<UserVM>> Get()
        {
            var response = await userRepository.Get();

            return mapper.Map<List<UserVM>>(response);
        }

        public async Task<UserVM> Get(Guid id)
        {
            var response = await userRepository.Get(id);

            return mapper.Map<UserVM>(response);
        }

        public async Task<UserVM> GetByEmail(string email)
        {
            var response = await userRepository.GetByEmail(email);

            return mapper.Map<UserVM>(response);
        }

        public async Task<UserAuthenticatedVM> CreateAndAuthenticate(UserVM model)
        {
            var password = model.Password;
            var user = await Post(model);

            if (model.Errors != null && model.Errors.Count > 0)
            {
                return new UserAuthenticatedVM
                {
                    Token = null,
                    User = user
                };
            }

            var login = await Login(model.Email, password);
            return login;
        }

        public async Task<UserVM> Post(UserVM model)
        {
            var validator = new CreateUserValidator();

            ValidationResult results = validator.Validate(model);

            Validation.AddErrors(model, results);

            var userByEmail = await userRepository.GetByEmail(model.Email);

            if (userByEmail != null)
            {
                model.AddError("E-mail already registered", "Email");
            }

            if (model.Errors != null && model.Errors.Count > 0) return model;

            model.Id = Guid.NewGuid();
            model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);

            var vmToModel = mapper.Map<User>(model);

            vmToModel.Token = NewUserToken();
            vmToModel.TokenExpirationDate = DateTime.UtcNow.AddDays(1);
            vmToModel.Active = false;

            await userRepository.Post(vmToModel);

            await RegisterSpentInMonth(model);

            var response = await emailService.SendEmail(model.Email, model.FullName, "User created with success", vmToModel.Token, vmToModel.Id.Value);

            return model;
        }

        public async Task<UserVM> Put(UserVM model)
        {
            var validator = new UpdateUserValidator();

            ValidationResult results = validator.Validate(model);

            Validation.AddErrors(model, results);

            var userByEmail = await userRepository.GetByEmail(model.Email, model.Id);

            if (userByEmail != null)
            {
                model.AddError("E-mail already registered", "Email");
            }

            if (model.Errors != null && model.Errors.Count > 0) return model;

            await userRepository.Put(mapper.Map<User>(model));

            return model;
        }

        public async Task<UserVM> Delete(Guid id)
        {
            var model = await userRepository.Get(id);

            if (model == null) return null;

            await userRepository.Delete(id);

            return mapper.Map<UserVM>(model);
        }

        private async Task RegisterSpentInMonth(UserVM model)
        {
            var monthList = await monthRepository.Get();

            foreach (var month in monthList)
            {
                var spentInMonth = new SpentInMonth
                {
                    Id = Guid.NewGuid(),
                    MonthId = month.Id,
                    UserId = model.Id,
                    SpendPercentageAbove = 0,
                    Spent = 0,
                };

                await spentInMonthRepository.Post(spentInMonth);
            }
        }

        public async Task<bool> ActivateUser(string token, Guid id)
        {
            return await userRepository.ActivateUser(token, id);
        }

        public async Task<bool> SendActivationEmail(Guid id)
        {
            var user = await userRepository.Get(id);

            if (user == null) return false;

            user.Token = NewUserToken();
            user.TokenExpirationDate = DateTime.UtcNow.AddDays(1);

            await userRepository.Put(mapper.Map<User>(user));

            var response = await emailService.SendEmail(user.Email, user.FullName, "User created with success", user.Token, user.Id.Value);

            if (!response.IsSuccessStatusCode) return false;

            return true;
        }

        private string NewUserToken()
        {
            return WebEncoders.Base64UrlEncode(GenerateRandomBytes(32));
        }

        private static byte[] GenerateRandomBytes(int numberOfBytes)
        {
            using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
            {
                byte[] byteArray = new byte[numberOfBytes];
                provider.GetBytes(byteArray);
                return byteArray;
            }
        }

        private async Task<UserAuthenticatedVM> Login(string email, string password)
        {
            var response = await authRepository.Login(email, password);
            return mapper.Map<UserAuthenticatedVM>(response);
            
        }

        
    }
}
