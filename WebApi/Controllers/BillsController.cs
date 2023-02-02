using api.Domain.Services.Interfaces;
using api.Domain.VM.Shared;
using Manager.VM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace api.Controllers
{
    [ApiController]
    [EnableCors("AllowAll")]
    [Route("v1/bills")]
    public class BillsController : ControllerBase
    {
        private readonly IBillService billService;

        public BillsController
        (
            IBillService billService
        )
        {
            this.billService = billService;
        }

        [HttpGet]
        [Route("")]
        [Authorize(Roles = "Admin")]
        public async Task<BaseResponse<List<BillVM>>> Get()
        {
            var response = await billService.Get();

            return new BaseResponse<List<BillVM>>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Success to list bills",
                Success = true,
                Data = response
            };
        }

        [HttpGet]
        [Route("{id:guid}")]
        [Authorize]
        public async Task<BaseResponse<BillVM>> Get([FromRoute] Guid id)
        {
            var response = await billService.Get(id);

            if (response == null)
            {
                return new BaseResponse<BillVM>()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = "Bill not found",
                    Success = false,
                    Data = null
                };
            }

            return new BaseResponse<BillVM>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Succes to get bill",
                Success = true,
                Data = response
            };
        }

        [HttpPost]
        [Route("")]
        public async Task<BaseResponse<BillVM>> Post([FromBody] BillVM model)
        {
            var response = await billService.Post(model);

            if (response.Errors != null)
            {
                return new BaseResponse<BillVM>()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = "Error to create bill",
                    Success = false,
                    Data = model
                };
            }

            return new BaseResponse<BillVM>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Success to create bill",
                Success = true,
                Data = response
            };
        }

        [HttpPut]
        [Route("")]
        [Authorize]
        public async Task<BaseResponse<BillVM>> Put([FromBody] BillVM model)
        {
            var response = await billService.Put(model);

            if (model.Errors != null)
            {
                return new BaseResponse<BillVM>()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = "Error to update bill",
                    Success = false,
                    Data = model
                };
            }

            return new BaseResponse<BillVM>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Success to update bill",
                Success = true,
                Data = model
            };
        }

        [HttpDelete]
        [Route("{id:guid}")]
        [Authorize]
        public async Task<BaseResponse<object>> Delete([FromRoute] Guid id)
        {
            var model = await billService.Delete(id);

            if (model == null)
            {
                return new BaseResponse<object>()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = "Bill not found",
                    Success = false,
                    Data = null
                };
            }

            return new BaseResponse<object>()
            {
                StatusCode = HttpStatusCode.OK,
                Message = "Success to delete bill",
                Success = true,
                Data = null
            };
        }
    }
}
