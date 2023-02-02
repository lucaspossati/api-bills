

using api.Domain.Services.Interfaces;
using api.Domain.VM.Shared;
using API.Domain.Models;
using API.Domain.VM;
using Application.Models;
using AutoMapper;
using Core.Validator;
using Core.Validator.User;
using Data.Repository.Interface;
using FluentValidation.Results;
using Manager.VM;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace api.Domain.Services
{
    public class BillService : IBillService
    {
        private readonly IMapper mapper;
        private readonly IBillRepository billRepository;

        public BillService(IMapper mapper, IBillRepository billRepository)
        {
            this.mapper = mapper;
            this.billRepository = billRepository;
        }

        public async Task<List<BillVM>> Get()
        {
            var response = await billRepository.Get();

            return mapper.Map<List<BillVM>>(response);
        }

        public async Task<BillVM> Get(Guid id)
        {
            var response = await billRepository.Get(id);

            return mapper.Map<BillVM>(response);
        }

        public async Task<BillVM> Post(BillVM model)
        {
            var validator = new CreateBillValidator();

            ValidationResult results = validator.Validate(model);

            Validation.AddErrors(model, results);

            if (model.Errors != null && model.Errors.Count > 0) return model;

            model.Id = Guid.NewGuid();

            var vmToModel = mapper.Map<Bill>(model);

            await billRepository.Post(vmToModel);

            return model;
        }

        public async Task<BillVM> Put(BillVM model)
        {
            var validator = new UpdateBillValidator();

            ValidationResult results = validator.Validate(model);

            Validation.AddErrors(model, results);

            if (model.Errors != null && model.Errors.Count > 0) return model;

            await billRepository.Put(mapper.Map<Bill>(model));

            return model;
        }

        public async Task<BillVM> Delete(Guid id)
        {
            var model = await billRepository.Get(id);

            if (model == null) return null;

            await billRepository.Delete(id);

            return mapper.Map<BillVM>(model); ;
        }
    }
}
