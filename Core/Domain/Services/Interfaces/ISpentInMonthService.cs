using Application.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Services.Interfaces
{
    public interface ISpentInMonthService
    {
        public Task<List<SpentInMonthVM>> Get();
        public Task<SpentInMonthVM> Get(Guid id);
        public Task<SpentInMonthVM> Post(SpentInMonthVM model);
        public Task<SpentInMonthVM> Put(SpentInMonthVM model);
        public Task<SpentInMonthVM> Delete(Guid id);
    }
}
