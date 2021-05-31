using Appforo.repositories;
using Appforo.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appforo
{
    public static  class IoC
    {

        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddTransient<IEstablishmentService, EstablishmentService>();
            services.AddTransient<IEstablishmentRepository, EstablishmentRepository>();

            return services;
        }
    }
}
