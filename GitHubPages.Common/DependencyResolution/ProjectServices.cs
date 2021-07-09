using GitHubPages.Common;
using GitHubPages.Common.Interfaces;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ProjectServices
    {
        public static void RegisterCommonServices(this IServiceCollection services)
        {
            services.AddScoped<IRestfulClient, RestfulClient>();
        }
    }
}
