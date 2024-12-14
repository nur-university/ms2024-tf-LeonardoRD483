using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Ingredientes;
using Microsoft.Extensions.DependencyInjection;

namespace GestionDeCocina.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddMediatR(config =>
              config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())
          );

            services.AddSingleton<IIngredienteFactory, IngredienteFactory>();

            return services;
        }
    }
}
