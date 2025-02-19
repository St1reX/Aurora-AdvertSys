using Application.Advert.Queries.GetAllAdverts;
using Application.Advert.Queries.GetFilteredAdverts;
using FluentValidation;
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
            services.AddValidatorsFromAssembly(typeof(GetFilteredAdvertsQueryValidator).Assembly);
        }
    }
}
