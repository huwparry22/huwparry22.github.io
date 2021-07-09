using GitHubPages.Objects.Results;
using GitHubPages.OfficialJokeApi.Responses;
using System.Collections.Generic;
using Xunit;

namespace GitHubPages.OfficialJokeApi.UnitTests.Mappers.TestData
{
    public static class JokeResultMapperTestData
    {
        public static TheoryData<IEnumerable<JokeResponse>, IEnumerable<JokeResult>> ToJokeResultCollectionTestData =>
            new TheoryData<IEnumerable<JokeResponse>, IEnumerable<JokeResult>>
            {
                { new List<JokeResponse> { GetTestCase().Item1 }, new List<JokeResult> { GetTestCase().Item2 } },
                { null, null }
            };

        public static TheoryData<JokeResponse, JokeResult> ToJokeResultSingleTestData =>
            new TheoryData<JokeResponse, JokeResult>
            {
                { GetTestCase().Item1, GetTestCase().Item2 }
            };

        private static (JokeResponse, JokeResult) GetTestCase()
        {
            return (
                new JokeResponse
                {
                    Id = 1,
                    Type = "testType",
                    Setup = "testSetup",
                    Punchline = "testPunchline"
                },
                new JokeResult
                {
                    Setup = "testSetup",
                    Punchline = "testPunchline"
                });
        }
    }
}
