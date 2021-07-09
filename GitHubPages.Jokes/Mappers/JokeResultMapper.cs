using GitHubPages.Objects.Results;
using GitHubPages.OfficialJokeApi.Interfaces;
using GitHubPages.OfficialJokeApi.Responses;

namespace GitHubPages.OfficialJokeApi.Mappers
{
    public class JokeResultMapper : IJokeResultMapper
    {
        public JokeResult ToJokeResult(JokeResponse jokeResponse)
        {
            return new JokeResult
            {
                Setup = jokeResponse.Setup,
                Punchline = jokeResponse.Punchline
            };
        }
    }
}
