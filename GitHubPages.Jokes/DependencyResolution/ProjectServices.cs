using GitHubPages.OfficialJokeApi.Interfaces;
using GitHubPages.OfficialJokeApi.Mappers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ProjectServices
    {
        public static void RegisterOfficialJokeApiServices(this IServiceCollection services)
        {
            services.AddScoped<IJokeResultMapper, JokeResultMapper>();
        }
    }
}
