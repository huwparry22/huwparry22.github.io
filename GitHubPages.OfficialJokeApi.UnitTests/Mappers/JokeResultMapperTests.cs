using FluentAssertions;
using GitHubPages.Objects.Results;
using GitHubPages.OfficialJokeApi.Mappers;
using GitHubPages.OfficialJokeApi.Responses;
using GitHubPages.OfficialJokeApi.UnitTests.Mappers.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GitHubPages.OfficialJokeApi.UnitTests.Mappers
{
    public class JokeResultMapperTests
    {
        private readonly JokeResultMapper _objectToTest;

        public JokeResultMapperTests()
        {
            _objectToTest = new JokeResultMapper();
        }

        public class ToJokeResultCollectionTests : JokeResultMapperTests
        {
            public ToJokeResultCollectionTests() : base() { }

            [Theory]
            [MemberData(nameof(JokeResultMapperTestData.ToJokeResultCollectionTestData), MemberType = typeof(JokeResultMapperTestData))]
            public void AssertMappings(IEnumerable<JokeResponse> jokeResponses, IEnumerable<JokeResult> expected)
            {
                var actual = _objectToTest.ToJokeResult(jokeResponses);

                //if (expected is null)
                //{
                //    Assert.Null(actual);
                //}
                //else
                //{
                //    //actual.Should().BeEquivalentTo(expected, )
                //}

                actual.Should().BeEquivalentTo(expected);
            }
        }

        public class ToJokeResultSingleTests : JokeResultMapperTests
        {
            public ToJokeResultSingleTests() : base() { }

            [Theory]
            [MemberData(nameof(JokeResultMapperTestData.ToJokeResultSingleTestData), MemberType = typeof(JokeResultMapperTestData))]
            public void AssertMappings(JokeResponse jokeResponse, JokeResult expected)
            {
                var actual = _objectToTest.ToJokeResult(jokeResponse);

                //AssertExpectedActualMappings(expected, actual);
                actual.Should().BeEquivalentTo(expected);
            }
        }
    }
}
