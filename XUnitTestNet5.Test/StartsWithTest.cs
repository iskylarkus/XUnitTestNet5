using Xunit;

namespace XUnitTestNet5.Test
{
    public class StartsWithTest
    {
        [Fact]
        public void StartsWithPassedTest()
        {
            Assert.StartsWith("ilker", "ilker selvi");
        }

        [Fact]
        public void StartsWithFailedTest()
        {
            Assert.StartsWith("selvi", "ilker selvi");
        }

        [Fact]
        public void EndsWithPassedTest()
        {
            Assert.EndsWith("selvi", "ilker selvi");
        }

        [Fact]
        public void EndsWithFailedTest()
        {
            Assert.EndsWith("ilker", "ilker selvi");
        }
    }
}
