using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infraestructure.Persistences.Interfaces;
using POS.Infraestructure.Persistences.Repositories;
using POST.Domain.Context;

namespace POS.Infraestructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection addInjectionInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            //var assembly = typeof(POSContext).Assembly.FullName;

            //services.AddDbContext<POSContext>(options =>
            //    options.UseSqlServer(
            //        configuration.GetConnectionString("POSConnection"),
            //        sqlOptions => sqlOptions.MigrationsAssembly(assembly)  
            //    ), ServiceLifetime.Scoped  // Cambiar a Scoped, no Transient
            //);
            services.AddDbContext<POSContext>(options =>
      options.UseSqlServer(configuration.GetConnectionString("POSConnection")));


            services.AddTransient<IUnitOfwork, UnitOfwork>();

            return services;
        }
    }
}
