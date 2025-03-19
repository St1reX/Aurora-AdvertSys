using Application.Services;
using Core.Entities;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Seeders;
using Infrastructure.Security;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //DB Context
            services.AddDbContext<AuroraDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Aurora")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AuroraDbContext>()
                .AddApiEndpoints()
                .AddDefaultTokenProviders();

            //DB Seeders
            services.AddScoped<AuroraBasicSeeder>();

            //HTTP Client
            services.AddHttpClient();

            //Authentication||Authorization
            services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;})
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = configuration["JWT:Issuer"],
                        ValidAudience = configuration["JWT:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]!))
                    };
                });
            services.AddAuthorization();
            services.AddScoped<IJWTGenerator, JWTGenerator>();

            //Repositories
            services.AddAdvertDependentInfrastructure();
            services.AddUserDependentInfrastructure();
            services.AddSharedInfrastructure();

            //Services
            services.AddScoped<ILocationService, GoogleMapsService>();

        }
    }
}
