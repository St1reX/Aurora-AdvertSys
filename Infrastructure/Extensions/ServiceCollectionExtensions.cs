using Application.Services;
using Core.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Seeders;
using Infrastructure.Repositories;
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
            services.AddScoped<IAdvertRepository, AdvertRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IWorkModelRepository, WorkModelRepository>();
            services.AddScoped<ISeniorityLevelRepository, SeniorityLevelRepository>();
            services.AddScoped<IJobSectorRepository, JobSectorRepository>();
            services.AddScoped<IEmploymentTypeRepository, EmploymentTypeRepository>();
            services.AddScoped<IContractTypeRepository, ContractTypeRepository>();

            //Services
            services.AddScoped<ILocationService, GoogleMapsService>();

        }
    }
}
