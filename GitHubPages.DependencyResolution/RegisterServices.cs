using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RegisterServices
    {
        public static void RegisterSolutionServices(this IServiceCollection services)
        {
            services.RegisterCommonServices();
            services.RegisterOfficialJokeApiServices();
            services.RegisterServicesServices();
        }
    }
}
