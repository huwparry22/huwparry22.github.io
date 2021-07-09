using FluentAssertions;
using GitHubPages.Common.Interfaces;
using GitHubPages.Objects.Results;
using GitHubPages.OfficialJokeApi.Interfaces;
using GitHubPages.OfficialJokeApi.Responses;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace GitHubPages.OfficialJokeApi.UnitTests
{
    public class JokeLogicTests
    {
        private readonly Mock<IRestfulClient> _mockRestfulClient;
        private readonly Mock<IJokeResultMapper> _mockJokeResultMapper;

        private readonly JokeLogic _objectToTest;

        public JokeLogicTests()
        {
            _mockRestfulClient = new Mock<IRestfulClient>();
            _mockJokeResultMapper = new Mock<IJokeResultMapper>();

            _objectToTest = new JokeLogic(_mockRestfulClient.Object, _mockJokeResultMapper.Object);
        }

        public class GetRandomJokeAsyncTests : JokeLogicTests
        {
            private readonly JokeResponse _jokeResponse;
            private readonly JokeResult _expected;

            public GetRandomJokeAsyncTests() : base()
            {
                _jokeResponse = new JokeResponse
                {
                    Id = 1,
                    Type = "TestType",
                    Setup = "TestSetup",
                    Punchline = "TestPunchline"
                };

                _mockRestfulClient
                    .Setup(x => x.GetAsync<JokeResponse>(It.IsAny<string>()))
                    .ReturnsAsync(_jokeResponse);

                _expected = new JokeResult
                {
                    Setup = "TestSetup",
                    Punchline = "TestPunchline"
                };

                _mockJokeResultMapper
                    .Setup(x => x.ToJokeResult(It.IsAny<JokeResponse>()))
                    .Returns(_expected);
            }

            [Fact]
            public async Task CallsRestfulClientGet()
            {
                await _objectToTest.GetRandomJokeAsync().ConfigureAwait(false);

                _mockRestfulClient
                    .Verify(x => x.GetAsync<JokeResponse>(It.IsAny<string>()));
            }

            [Fact]
            public async Task CallsRestfulClientGetOnce()
            {
                await _objectToTest.GetRandomJokeAsync().ConfigureAwait(false);

                _mockRestfulClient
                    .Verify(x => x.GetAsync<JokeResponse>(It.IsAny<string>()), Times.Once);
            }

            [Fact]
            public async Task CallsRestfulClientGetWithJokeGetRandomUrl()
            {
                await _objectToTest.GetRandomJokeAsync().ConfigureAwait(false);

                _mockRestfulClient
                    .Verify(x => x.GetAsync<JokeResponse>(Constants.JOKE_GET_RANDOM_URL));
            }

            [Fact]
            public async Task CallsJokeResultMapperToJokeResult()
            {
                await _objectToTest.GetRandomJokeAsync().ConfigureAwait(false);

                _mockJokeResultMapper
                    .Verify(x => x.ToJokeResult(It.IsAny<JokeResponse>()));
            }

            [Fact]
            public async Task CallsJokeResultMapperToJokeResultOnce()
            {
                await _objectToTest.GetRandomJokeAsync().ConfigureAwait(false);

                _mockJokeResultMapper
                    .Verify(x => x.ToJokeResult(It.IsAny<JokeResponse>()), Times.Once);
            }

            [Fact]
            public async Task CallsJokeResultMapperToJokeResultWithJokeResponse()
            {
                await _objectToTest.GetRandomJokeAsync().ConfigureAwait(false);

                _mockJokeResultMapper
                    .Verify(x => x.ToJokeResult(_jokeResponse));
            }

            [Fact]
            public async Task ReturnsCorrectJokeResult()
            {
                var actual = await _objectToTest.GetRandomJokeAsync().ConfigureAwait(false);

                actual.Should().BeEquivalentTo(_expected);
            }
        }
    }
}
