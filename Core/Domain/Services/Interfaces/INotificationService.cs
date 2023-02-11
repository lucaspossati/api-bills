using api.Domain.VM.Shared;
using API.Domain.Models;
using API.Domain.VM;
using API.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Domain.Services.Interfaces
{
    public interface INotificationService
    {
        Task<BaseResponse<List<NotificationVM>>> Get(ETypeNotification? filter);
        Task<BaseResponse<NotificationVM>> Get(Guid id);
        Task<BaseResponse<NotificationVM>> Post(NotificationVM model);
        Task<BaseResponse<NotificationVM>> Put(NotificationVM model);
        Task<BaseResponse<object>> Delete(Guid id);
    }
}
