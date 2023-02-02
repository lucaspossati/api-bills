
using api.Profiles;
using Core.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace api.Configuration
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(NotificationProfile), 
                typeof(UserProfile),
                typeof(BillProfile),
                typeof(SpentInMonthProfile));

        }
    }
}
