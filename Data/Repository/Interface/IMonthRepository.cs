using API.Domain.Models;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IMonthRepository
    {
        Task<List<Month>> Get();
    }
}
