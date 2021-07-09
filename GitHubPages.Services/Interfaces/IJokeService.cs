using GitHubPages.Objects.Results;
using System.Threading.Tasks;

namespace GitHubPages.Services.Interfaces
{
    public interface IJokeService
    {
        Task<JokeResult> GetRandomJokeAsync();
    }
}
