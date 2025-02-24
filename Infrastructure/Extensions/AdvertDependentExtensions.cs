using Core.Interfaces.AdvertDependent;
using Infrastructure.Repositories.AdvertDependent;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class AdvertDependentExtensions
    {
        public static void AddAdvertDependentInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IAdvertRepository, AdvertRepository>();
            services.AddScoped<IWorkModelRepository, WorkModelRepository>();
            services.AddScoped<ISeniorityLevelRepository, SeniorityLevelRepository>();
            services.AddScoped<IJobSectorRepository, JobSectorRepository>();
            services.AddScoped<IEmploymentTypeRepository, EmploymentTypeRepository>();
            services.AddScoped<IContractTypeRepository, ContractTypeRepository>();
        }
    }
}
