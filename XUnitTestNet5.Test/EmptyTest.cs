using System.Collections.Generic;
using Xunit;

namespace XUnitTestNet5.Test
{
    public class EmptyTest
    {
        [Fact]
        public void EmptyPassedTest()
        {
            Assert.Empty(new List<string>());
        }

        [Fact]
        public void EmptyFailedTest()
        {
            Assert.Empty(new List<string>() { "ilker", "selvi" });
        }

        [Fact]
        public void NotEmptyPassedTest()
        {
            Assert.NotEmpty(new List<string>() { "ilker", "selvi" });
        }

        [Fact]
        public void NotEmptyFailedTest()
        {
            Assert.NotEmpty(new List<string>());
        }
    }
}
