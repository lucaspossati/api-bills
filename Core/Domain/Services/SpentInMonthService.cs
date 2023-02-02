using Application.Models;
using Application.VM;
using AutoMapper;
using Core.Domain.Services.Interfaces;
using Core.Validator;
using Core.Validator.SpentInMonth;
using Data.Repository.Interface;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Services
{
    public class SpentInMonthService : ISpentInMonthService
    {
        private readonly IMapper mapper;
        private readonly ISpentInMonthRepository spentInMonthRepository;

        public SpentInMonthService(IMapper mapper, ISpentInMonthRepository spentInMonthRepository)
        {
            this.mapper = mapper;
            this.spentInMonthRepository = spentInMonthRepository;
        }

        public async Task<List<SpentInMonthVM>> Get()
        {
            var response = await spentInMonthRepository.Get();

            return mapper.Map<List<SpentInMonthVM>>(response);
        }

        public async Task<SpentInMonthVM> Get(Guid id)
        {
            var response = await spentInMonthRepository.Get(id);

            return mapper.Map<SpentInMonthVM>(response);
        }

        public async Task<SpentInMonthVM> Post(SpentInMonthVM model)
        {
            var validator = new CreateSpentInMonthValidator();

            ValidationResult results = validator.Validate(model);

            Validation.AddErrors(model, results);

            if (model.Errors != null && model.Errors.Count > 0) return model;

            model.Id = Guid.NewGuid();

            var vmToModel = mapper.Map<SpentInMonth>(model);

            await spentInMonthRepository.Post(vmToModel);

            return model;
        }

        public async Task<SpentInMonthVM> Put(SpentInMonthVM model)
        {
            var validator = new CreateSpentInMonthValidator();

            ValidationResult results = validator.Validate(model);

            Validation.AddErrors(model, results);

            if (model.Errors != null && model.Errors.Count > 0) return model;

            await spentInMonthRepository.Put(mapper.Map<SpentInMonth>(model));

            return model;
        }

        public async Task<SpentInMonthVM> Delete(Guid id)
        {
            var model = await spentInMonthRepository.Get(id);

            if (model == null) return null;

            await spentInMonthRepository.Delete(id);

            return mapper.Map<SpentInMonthVM>(model); ;
        }
    }
}
