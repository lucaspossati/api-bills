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
        Task<List<SpentInMonthVM>> Get();
        Task<SpentInMonthVM> Get(Guid id);
        Task<SpentInMonthVM> Post(SpentInMonthVM model);
        Task<SpentInMonthVM> Put(SpentInMonthVM model);
        Task<SpentInMonthVM> Delete(Guid id);
    }
}
