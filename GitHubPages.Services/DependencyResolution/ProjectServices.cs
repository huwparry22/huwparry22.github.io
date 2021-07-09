using GitHubPages.OfficialJokeApi;
using GitHubPages.Services;
using GitHubPages.Services.Factory;
using GitHubPages.Services.Interfaces;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ProjectServices
    {
        public static void RegisterServicesServices(this IServiceCollection services)
        {
            services.AddScoped<IJokeService, JokeService>();
            services.AddScoped<IJokeLogic, JokeLogic>();
        }
    }
}
