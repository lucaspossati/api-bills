using api.Domain.Services.Interfaces;
using api.Domain.VM.Shared;
using API.Domain.VM;
using API.ValueObjects;
using AutoMapper;
using Azure;
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
    [Route("v1/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController
        (
            IUserService userService
        )
        {
            this.userService = userService;
        }

        [HttpGet]
        [Route("")]
        [Authorize(Roles = "Admin")]
        public async Task<BaseResponse<List<UserVM>>> Get()
        {
            var response = await userService.Get();

            return new BaseResponse<List<UserVM>>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Success to list users",
                Success = true,
                Data = response
            };
        }

        [HttpGet]
        [Route("{id:guid}")]
        [Authorize]
        public async Task<BaseResponse<UserVM>> Get([FromRoute] Guid id)
        {
            var response = await userService.Get(id);

            if (response == null)
            {
                return new BaseResponse<UserVM>()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = "User not found",
                    Success = false,
                    Data = null
                };
            }

            return new BaseResponse<UserVM>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Succes to get user",
                Success = true,
                Data = response
            };
        }

        [HttpGet]
        [Route("get-by-email/{email}")]
        [Authorize]
        public async Task<BaseResponse<UserVM>> GetByEmail([FromRoute] string email)
        {
            var response = await userService.GetByEmail(email);

            if (response == null)
            {
                return new BaseResponse<UserVM>()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = "User not found",
                    Success = false,
                    Data = null
                };
            }

            return new BaseResponse<UserVM>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Succes to get user",
                Success = true,
                Data = response
            };
        }

        [HttpPost]
        [Route("create-and-authenticate")]
        public async Task<BaseResponse<UserAuthenticatedVM>> CreateAndAuthenticate([FromBody] UserVM model)
        {
            var response = await userService.CreateAndAuthenticate(model);

            if (response.Token == null)
            {
                return new BaseResponse<UserAuthenticatedVM>()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = "Error to create user",
                    Success = false,
                    Data = response
                };
            }

            return new BaseResponse<UserAuthenticatedVM>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Success to create user",
                Success = true,
                Data = response
            };
        }

        [HttpPost]
        [Route("")]
        public async Task<BaseResponse<UserVM>> Post([FromBody] UserVM model)
        {
            var response = await userService.Post(model);

            if (response.Errors != null)
            {
                return new BaseResponse<UserVM>()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = "Error to create user",
                    Success = false,
                    Data = model
                };
            }

            return new BaseResponse<UserVM>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Success to create user",
                Success = true,
                Data = response
            };
        }

        [HttpPut]
        [Route("")]
        [Authorize]
        public async Task<BaseResponse<UserVM>> Put([FromBody] UserVM model)
        {
            var response = await userService.Put(model);

            if (response.Errors != null)
            {
                return new BaseResponse<UserVM>()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = "Error to update user",
                    Success = false,
                    Data = model
                };
            }

            return new BaseResponse<UserVM>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Success to update user",
                Success = true,
                Data = model
            };
        }

        [HttpDelete]
        [Route("{id:guid}")]
        [Authorize]
        public async Task<BaseResponse<object>> Delete([FromRoute] Guid id)
        {
            var model = await userService.Delete(id);

            if (model == null)
            {
                return new BaseResponse<object>()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = "User not found",
                    Success = false,
                    Data = null
                };
            }

            return new BaseResponse<object>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Success to delete user",
                Success = true,
                Data = null
            };
        }
    }
}
