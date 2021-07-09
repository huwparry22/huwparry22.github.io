using GitHubPages.Common.Interfaces;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace GitHubPages.Common
{
    public class RestfulClient : IRestfulClient
    {
        public async Task<T> GetAsync<T>(string url)
        {
            var client = new RestClient();

            var request = new RestRequest(url, Method.GET, DataFormat.Json);

            var response = await client.ExecuteAsync<T>(request).ConfigureAwait(false);

            return response.Data;
        }
    }
}
