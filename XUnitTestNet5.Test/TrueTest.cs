using Xunit;

namespace XUnitTestNet5.Test
{
    public class TrueTest
    {
        [Fact]
        public void TruePassedTest()
        {
            Assert.True(5 > 3);
        }

        [Fact]
        public void TrueFailedTest()
        {
            Assert.True(5 < 3);
        }

        [Fact]
        public void FalsePassedTest()
        {
            Assert.False("".GetType() == typeof(int));
        }

        [Fact]
        public void FalseFailedTest()
        {
            Assert.False("".GetType() == typeof(string));
        }
    }
}
