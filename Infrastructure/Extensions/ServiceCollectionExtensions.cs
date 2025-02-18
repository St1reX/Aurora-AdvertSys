using Application.Services;
using Core.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Seeders;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AuroraDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Aurora")));

            services.AddHttpClient();
            
            services.AddScoped<AuroraBasicSeeder>();


            services.AddScoped<IAdvert, AdvertRepository>();
            services.AddScoped<IAddress, AddressRepository>();
            services.AddScoped<ILocationService, GoogleMapsService>();
        }
    }
}
