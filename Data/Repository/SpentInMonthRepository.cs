
using API.Data;
using Application.Models;
using Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class SpentInMonthRepository : ISpentInMonthRepository
    {
        private readonly DataContext context;

        public SpentInMonthRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<SpentInMonth>> Get()
        {
            return await context.SpentInMonth.ToListAsync();
        }

        public async Task<SpentInMonth> Get(Guid id)
        {
            return await context.SpentInMonth.FindAsync(id);
        }

        public async Task<SpentInMonth> Post(SpentInMonth model)
        {
            context.SpentInMonth.Add(model);

            await context.SaveChangesAsync();

            return model;
        }

        public async Task<SpentInMonth> Put(SpentInMonth model)
        {
            context.Entry(model).State = EntityState.Modified;

            await context.SaveChangesAsync();

            return model;
        }

        public async Task Delete(Guid id)
        {
            var model = await context.SpentInMonth.FindAsync(id);

            context.SpentInMonth.Remove(model);

            await context.SaveChangesAsync();
        }
    }
}
