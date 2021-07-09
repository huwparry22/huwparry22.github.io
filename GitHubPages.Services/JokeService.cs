using GitHubPages.Objects.Results;
using GitHubPages.Services.Factory;
using GitHubPages.Services.Interfaces;
using System.Threading.Tasks;

namespace GitHubPages.Services
{
    public class JokeService : IJokeService
    {
        private readonly IJokeLogic _jokeLogic;

        public JokeService(IJokeLogic jokeLogic)
        {
            _jokeLogic = jokeLogic;
        }

        public async Task<JokeResult> GetRandomJokeAsync()
        {
            return await _jokeLogic.GetRandomJokeAsync().ConfigureAwait(false);
        }
    }
}
