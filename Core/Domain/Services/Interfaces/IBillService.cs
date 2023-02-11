using api.Domain.VM.Shared;
using API.Domain.Models;
using API.Domain.VM;
using API.ValueObjects;
using Manager.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Domain.Services.Interfaces
{
    public interface IBillService
    {
        Task<List<BillVM>> Get();
        Task<BillVM> Get(Guid id);
        Task<BillVM> Post(BillVM model);
        Task<BillVM> Put(BillVM model);
        Task<BillVM> Delete(Guid id);
    }
}
