using Application.Services;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Seeders;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Core.Entities;

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

            //HTTP Client
            services.AddHttpClient();

            //DB Seeders
            services.AddScoped<AuroraBasicSeeder>();

            //Repositories
            services.AddAdvertDependentInfrastructure();
            services.AddUserDependentInfrastructure();
            services.AddSharedInfrastructure();

            //Services
            services.AddScoped<ILocationService, GoogleMapsService>();

        }
    }
}
