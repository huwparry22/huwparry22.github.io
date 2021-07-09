using System.Threading.Tasks;

namespace GitHubPages.Common.Interfaces
{
    public interface IRestfulClient
    {
        Task<T> GetAsync<T>(string url);
    }
}
