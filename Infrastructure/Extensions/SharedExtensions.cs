using Core.Interfaces.AdvertDependent;
using Core.Interfaces.Shared;
using Infrastructure.Repositories.AdvertDependent;
using Infrastructure.Repositories.Shared;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class SharedExtensions
    {
        public static void AddSharedInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
        }
    }
}
