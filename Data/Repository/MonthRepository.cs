using API.Data;
using API.Domain.Models;
using API.ValueObjects;
using Application.Models;
using Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class MonthRepository : IMonthRepository
    {
        private readonly DataContext context;

        public MonthRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<Month>> Get()
        {
            return await context.Months.ToListAsync();
        }
    }
}
