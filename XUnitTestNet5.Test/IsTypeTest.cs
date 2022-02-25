using Xunit;

namespace XUnitTestNet5.Test
{
    public class IsTypeTest
    {
        [Fact]
        public void IsTypePassedTest()
        {
            Assert.IsType<string>("ilker");
        }

        [Fact]
        public void IsTypeFailedTest()
        {
            Assert.IsType<int>("ilker");
        }

        [Fact]
        public void IsNotTypePassedTest()
        {
            Assert.IsNotType<int>("ilker");
        }

        [Fact]
        public void IsNotTypeFailedTest()
        {
            Assert.IsNotType<string>("ilker");
        }
    }
}
