using GitHubPages.Common.Interfaces;
using GitHubPages.Objects.Results;
using GitHubPages.OfficialJokeApi.Interfaces;
using GitHubPages.OfficialJokeApi.Responses;
using GitHubPages.Services.Interfaces;
using System.Threading.Tasks;

namespace GitHubPages.OfficialJokeApi
{
    public class JokeLogic : IJokeLogic
    {
        private readonly IRestfulClient _restfulClient;
        private readonly IJokeResultMapper _jokeResultMapper;

        public JokeLogic(IRestfulClient restfulClient, IJokeResultMapper jokeResultMapper)
        {
            _restfulClient = restfulClient;
            _jokeResultMapper = jokeResultMapper;
        }

        public async Task<JokeResult> GetRandomJokeAsync()
        {
            var jokeResponse = await _restfulClient.GetAsync<JokeResponse>(Constants.JOKE_GET_RANDOM_URL).ConfigureAwait(false);

            return _jokeResultMapper.ToJokeResult(jokeResponse);
        }
    }
}
