using Xunit;

namespace XUnitTestNet5.Test
{
    public class EqualTest
    {
        [Fact]
        public void EqualPassedTest()
        {
            Assert.Equal(25, 25);
        }

        [Fact]
        public void EqualFailedTest()
        {
            Assert.Equal<int>(25, 10);
        }

        [Fact]
        public void NotEqualPassedTest()
        {
            Assert.NotEqual(25, 10);
        }

        [Fact]
        public void NotEqualFailedTest()
        {
            Assert.NotEqual<int>(25, 25);
        }
    }
}
