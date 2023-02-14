
using Application.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IBillRepository
    {
        Task<IEnumerable<Bill>> Get(Guid userId, Guid monthId);

        Task<Bill?> Get(Guid id);

        Task<Bill> Post(Bill model);

        Task<Bill> Put(Bill model);

        Task Delete(Guid id);
    }
}
