using Xunit;

namespace XUnitTestNet5.Test
{
    public class InRangeTest
    {
        [Fact]
        public void InRangePassedTest()
        {
            Assert.InRange(10, 2, 20);
        }

        [Fact]
        public void InRangeFailedTest()
        {
            Assert.InRange(25, 2, 20);
        }

        [Fact]
        public void NotInRangePassedTest()
        {
            Assert.NotInRange(25, 2, 20);
        }

        [Fact]
        public void NotInRangeFailedTest()
        {
            Assert.NotInRange(10, 2, 20);
        }
    }
}
