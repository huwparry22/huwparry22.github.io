using GitHubPages.Objects.Results;
using System.Threading.Tasks;

namespace GitHubPages.Services.Factory
{
    public interface IJokeLogic
    {
        Task<JokeResult> GetRandomJokeAsync();
    }
}
