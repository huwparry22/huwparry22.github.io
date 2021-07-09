using GitHubPages.Objects.Results;
using GitHubPages.OfficialJokeApi.Responses;

namespace GitHubPages.OfficialJokeApi.Interfaces
{
    public interface IJokeResultMapper
    {
        JokeResult ToJokeResult(JokeResponse jokeResponse);
    }
}
