using Data.Services;
using Data.Services.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CL.WebApi.Configuration;

public static class JwtConfig
{
    public static void AddJwtTConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IJWTService, JWTService>();

        var secret = configuration.GetSection("JWT:Secret").Value;
        var key = Encoding.ASCII.GetBytes(secret == null ? "" : secret);

        services.AddAuthentication(p =>
        {
           p.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
           p.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(p =>
        {
            p.RequireHttpsMetadata = false;
            p.SaveToken = true;
            p.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
            };
        });
    }

    public static void UseJwtConfiguration(this IApplicationBuilder app)
    {
        app.UseAuthentication();
        app.UseAuthorization();
    }
}