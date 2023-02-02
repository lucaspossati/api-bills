

using api.Domain.Services.Interfaces;
using api.Domain.VM.Shared;
using API.Domain.Models;
using API.Domain.VM;
using Application.Models;
using Application.VM;
using AutoMapper;
using Core.Validator;
using Core.Validator.User;
using Data.Repository.Interface;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace api.Domain.Services
{
    public class UserService: IUserService
    {
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;
        private readonly ISpentInMonthRepository spentInMonthRepository;
        private readonly IMonthRepository monthRepository;

        public UserService(
            IMapper mapper, 
            IUserRepository userRepository,
            IMonthRepository monthRepository,
            ISpentInMonthRepository spentInMonthRepository)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
            this.spentInMonthRepository = spentInMonthRepository;
            this.monthRepository = monthRepository;
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

            await userRepository.Post(vmToModel);

            await RegisterSpentInMonth(model);

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

            return mapper.Map<UserVM>(model); ;
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
    }
}
