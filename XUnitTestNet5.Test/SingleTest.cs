using System.Collections.Generic;
using Xunit;

namespace XUnitTestNet5.Test
{
    public class SingleTest
    {
        [Fact]
        public void SinglePassedTest()
        {
            Assert.Single(new List<string>() { "ilker" });
        }

        [Fact]
        public void SingleFailedTest()
        {
            Assert.Single(new List<string>() { "ilker", "selvi" });
        }

        [Fact]
        public void GenericSinglePassedTest()
        {
            Assert.Single<int>(new List<int>() { 19 });
        }

        [Fact]
        public void GenericSingleFailedTest()
        {
            Assert.Single<int>(new List<int>() { 19, 11 });
        }
    }
}
