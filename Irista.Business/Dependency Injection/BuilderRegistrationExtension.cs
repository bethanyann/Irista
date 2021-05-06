using Irista.Business.Builders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Irista.Business.Dependency_Injection
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
