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
        public Task<List<BillVM>> Get();
        public Task<BillVM> Get(Guid id);
        public Task<BillVM> Post(BillVM model);
        public Task<BillVM> Put(BillVM model);
        public Task<BillVM> Delete(Guid id);
    }
}
