using GitHubPages.Objects.Results;
using GitHubPages.OfficialJokeApi.Responses;
using System.Collections.Generic;

namespace GitHubPages.OfficialJokeApi.Interfaces
{
    public interface IJokeResultMapper
    {
        IEnumerable<JokeResult> ToJokeResult(IEnumerable<JokeResponse> jokeResponses);

        JokeResult ToJokeResult(JokeResponse jokeResponse);
    }
}
