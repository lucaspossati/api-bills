using api.Domain.Services.Interfaces;
using api.Domain.VM.Shared;
using API.Domain.VM;
using API.ValueObjects;
using Application.VM;
using AutoMapper;
using Azure;
using Core.Domain.Services.Interfaces;
using Data.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace api.Controllers
{
    [ApiController]
    [EnableCors("AllowAll")]
    [Route("v1/spents-in-month")]
    public class SpentInMonthController : ControllerBase
    {
        private readonly ISpentInMonthService spentInMonthService;

        public SpentInMonthController
        (
            ISpentInMonthService spentInMonthService
        )
        {
            this.spentInMonthService = spentInMonthService;
        }

        [HttpGet]
        [Route("")]
        [Authorize]
        public async Task<BaseResponse<List<SpentInMonthVM>>> Get()
        {
            var response = await spentInMonthService.Get();

            return new BaseResponse<List<SpentInMonthVM>>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Success to list spents in month",
                Success = true,
                Data = response
            };
        }

        [HttpGet]
        [Route("{id:guid}")]
        [Authorize]
        public async Task<BaseResponse<SpentInMonthVM>> Get([FromRoute] Guid id)
        {
            var response = await spentInMonthService.Get(id);

            if (response == null)
            {
                return new BaseResponse<SpentInMonthVM>()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = "Spents not found",
                    Success = false,
                    Data = null
                };
            }

            return new BaseResponse<SpentInMonthVM>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Succes to get spents in month",
                Success = true,
                Data = response
            };
        }

        [HttpGet]
        [Route("get-by-id-user/{id:guid}")]
        [Authorize]
        public async Task<BaseResponse<IEnumerable<SpentInMonthVM>>> GetByIdUser([FromRoute] Guid id)
        {
            var response = await spentInMonthService.GetByIdUser(id);

            if (response == null)
            {
                return new BaseResponse<IEnumerable<SpentInMonthVM>>()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = "Spents not found",
                    Success = false,
                    Data = null
                };
            }

            return new BaseResponse<IEnumerable<SpentInMonthVM>>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Succes to get spents in month",
                Success = true,
                Data = response
            };
        }
    }
}
