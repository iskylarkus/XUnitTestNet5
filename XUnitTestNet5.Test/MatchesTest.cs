using Xunit;

namespace XUnitTestNet5.Test
{
    public class MatchesTest
    {
        [Fact]
        public void MatchPassedTest()
        {
            var regex = "^ilker";

            Assert.Matches(regex, "ilker selvi");
        }

        [Fact]
        public void MatchesFailedTest()
        {
            var regex = "^ilker";

            Assert.Matches(regex, "selvi ilker");
        }

        [Fact]
        public void DoesNotMatchPassedTest()
        {
            var regex = "^ilker";

            Assert.DoesNotMatch(regex, "selvi ilker");
        }

        [Fact]
        public void DoesNotMatchFailedTest()
        {
            var regex = "^ilker";

            Assert.DoesNotMatch(regex, "ilker selvi");
        }
    }
}
