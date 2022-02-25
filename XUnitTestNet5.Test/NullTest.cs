using Xunit;

namespace XUnitTestNet5.Test
{
    public class NullTest
    {
        [Fact]
        public void NullPassedTest()
        {
            string name = null;

            Assert.Null(name);
        }

        [Fact]
        public void NullFailedTest()
        {
            string name = "ilker";

            Assert.Null(name);
        }

        [Fact]
        public void NotNullPassedTest()
        {
            string name = "ilker";

            Assert.NotNull(name);
        }

        [Fact]
        public void NotNullFailedTest()
        {
            string name = null;

            Assert.NotNull(name);
        }
    }
}
