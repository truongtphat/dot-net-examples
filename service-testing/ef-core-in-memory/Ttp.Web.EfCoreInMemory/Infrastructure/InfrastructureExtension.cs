using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ttp.Web.EfCoreInMemory.Application.Interfaces;

namespace Ttp.Web.EfCoreInMemory.Infrastructure
{
    public static class InfrastructureExtension
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseInMemoryDatabase("EfCoreInMemoryDb");
            });

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

            return services;
        }
    }
}
