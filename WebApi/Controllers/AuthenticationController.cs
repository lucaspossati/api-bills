using api.Domain.Services.Interfaces;
using api.Domain.VM.Shared;
using API.Domain.VM;
using API.ValueObjects;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace api.Controllers
{
    [ApiController]
    [EnableCors("AllowAll")]
    [Route("v1/authentication")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService authenticationService;

        public AuthenticationController
        (
            IAuthenticationService authenticationService
        )
        {
            this.authenticationService = authenticationService;
        }

        [HttpPost]
        [Route("")]
        public async Task<BaseResponse<dynamic>> Login([FromBody] LoginVM login)
        {
            var response = await authenticationService.Login(login.Email, login.Password);

            if (response == null)
            {
                return new BaseResponse<dynamic>()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = "Email or password invalid",
                    Success = false,
                    Data = login
                };
            }

            return new BaseResponse<dynamic>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Authenticated",
                Success = true,
                Data = response
            };
        }

    }
}
