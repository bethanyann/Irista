using Irista.Business.Builders;
using Microsoft.Extensions.DependencyInjection;


namespace Irista.Business.DependencyInjection
{
    public static class BuilderRegistrationExtension
    {
        public static IServiceCollection AddBuildersToServiceProvider(this IServiceCollection services)
        {
            services.AddScoped<PhotoBuilder>();
            return services;
        }
    }
}
