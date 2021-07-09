using GitHubPages.Objects.Results;
using GitHubPages.Services.Factory;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace GitHubPages.Services.UnitTests
{
    public class JokeServiceTests
    {
        private readonly Mock<IJokeLogic> _mockJokeLogic;

        private readonly JokeService _objectToTest;

        public JokeServiceTests()
        {
            _mockJokeLogic = new Mock<IJokeLogic>();

            _objectToTest = new JokeService(_mockJokeLogic.Object);
        }

        public class GetRandomJokeAsyncTests : JokeServiceTests
        {
            private readonly JokeResult _expected;

            public GetRandomJokeAsyncTests() : base()
            {
                _expected = new JokeResult
                {
                    Setup = "MockSetup",
                    Punchline = "MockPunchline"
                };

                _mockJokeLogic
                    .Setup(x => x.GetRandomJokeAsync())
                    .ReturnsAsync(_expected);
            }

            [Fact]
            public async Task CallsJokeLogicOnce()
            {
                await _objectToTest.GetRandomJokeAsync().ConfigureAwait(false);

                _mockJokeLogic
                    .Verify(x => x.GetRandomJokeAsync(), Times.Once);
            }

            [Fact]
            public async Task ReturnsMockJokeResult()
            {
                var actual = await _objectToTest.GetRandomJokeAsync().ConfigureAwait(false);

                Assert.Equal(_expected, actual);
            }
        }
    }
}
