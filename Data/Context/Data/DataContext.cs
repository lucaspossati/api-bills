using API.Domain.Models;
using Application.Models;
using Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace API.Data{
    public class DataContext: DbContext
    {
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<SpentInMonth> SpentInMonth { get; set; }
        public DbSet<Bill> Bill { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new NotificationConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new MonthConfiguration());
            modelBuilder.ApplyConfiguration(new SpentInMonthConfiguration());
            modelBuilder.ApplyConfiguration(new BillConfiguration());
        }
    }
}