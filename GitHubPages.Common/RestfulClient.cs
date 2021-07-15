using Flurl.Http;
using GitHubPages.Common.Interfaces;
using System.Threading.Tasks;

namespace GitHubPages.Common
{
    public class RestfulClient : IRestfulClient
    {
        public async Task<T> GetAsync<T>(string url)
        {
            return await url.GetJsonAsync<T>().ConfigureAwait(false);
        }
    }
}
