using Application.Services;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Seeders;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //DB Context
            services.AddDbContext<AuroraDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Aurora")));

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
