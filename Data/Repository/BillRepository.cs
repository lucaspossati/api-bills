
using API.Data;
using Application.Models;
using Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BillRepository : IBillRepository
    {
        private readonly DataContext context;

        public BillRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<Bill>> Get()
        {
            return await context.Bill.ToListAsync();
        }

        public async Task<Bill?> Get(Guid id)
        {
            return await context.Bill.FindAsync(id);
        }

        public async Task<Bill> Post(Bill model)
        {
            context.Bill.Add(model);

            await context.SaveChangesAsync();

            return model;
        }

        public async Task<Bill> Put(Bill model)
        {
            context.Entry(model).State = EntityState.Modified;

            await context.SaveChangesAsync();

            return model;
        }

        public async Task Delete(Guid id)
        {
            var model = await context.Bill.FindAsync(id);

            if (model == null) return;

            context.Bill.Remove(model);

            await context.SaveChangesAsync();
        }
    }
}
