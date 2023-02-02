using api.Domain.Services;
using api.Domain.Services.Interfaces;
using Application.Models;
using Core.Domain.Services;
using Core.Domain.Services.Interfaces;
using Data.Repository;
using Data.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<INotificationRepository, NotificationRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();

            services.AddScoped<ISpentInMonthService, SpentInMonthService>();
            services.AddScoped<ISpentInMonthRepository, SpentInMonthRepository>();

            services.AddScoped<IBillService, BillService>();
            services.AddScoped<IBillRepository, BillRepository>();

            services.AddScoped<IMonthRepository, MonthRepository>();
        }
    }
}
