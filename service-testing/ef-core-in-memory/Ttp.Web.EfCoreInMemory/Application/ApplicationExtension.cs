using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Ttp.Web.EfCoreInMemory.Application
{
    public static class ApplicationExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ApplicationExtension));
            return services;
        }
    }
}
