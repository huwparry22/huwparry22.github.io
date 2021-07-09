using GitHubPages.Objects.Results;
using GitHubPages.OfficialJokeApi.Interfaces;
using GitHubPages.OfficialJokeApi.Responses;
using System.Collections.Generic;

namespace GitHubPages.OfficialJokeApi.Mappers
{
    public class JokeResultMapper : IJokeResultMapper
    {
        public IEnumerable<JokeResult> ToJokeResult(IEnumerable<JokeResponse> jokeResponses)
        {
            if (jokeResponses is null)
                return null;

            var jokeResults = new List<JokeResult>();

            foreach(var jokeResponse in jokeResponses)
            {
                jokeResults.Add(ToJokeResult(jokeResponse));
            }

            return jokeResults;
        }

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
