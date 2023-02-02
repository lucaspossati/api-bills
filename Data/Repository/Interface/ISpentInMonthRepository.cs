
using Application.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface ISpentInMonthRepository
    {
        Task<List<SpentInMonth>> Get();

        Task<SpentInMonth> Get(Guid id);

        Task<SpentInMonth> Post(SpentInMonth model);

        Task<SpentInMonth> Put(SpentInMonth model);

        Task Delete(Guid id);
    }
}
