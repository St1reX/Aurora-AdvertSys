using Application.AdvertDependent.Advert.Queries.GetAllAdverts;
using Application.AdvertDependent.Advert.Queries.GetFilteredAdverts;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllAdvertsQuery).Assembly));

            services.AddValidatorsFromAssemblyContaining<GetFilteredAdvertsQueryValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
        }
    }
}
