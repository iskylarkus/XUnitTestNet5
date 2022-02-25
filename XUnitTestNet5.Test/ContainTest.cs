using System.Collections.Generic;
using Xunit;

namespace XUnitTestNet5.Test
{
    public class ContainTest
    {
        [Fact]
        public void RunContainPassedTest()
        {
            //Assert
            Assert.Contains("ilker", "ilker selvi");
        }

        [Fact]
        public void RunContainFailedTest()
        {
            //Assert
            Assert.Contains("fatih", "ilker selvi");
        }

        [Fact]
        public void RunDoesNotContainPassedTest()
        {
            var names = new List<string>() { "fatih", "ilker", "selvi" };

            Assert.DoesNotContain(names, x => x == "emin");
        }

        [Fact]
        public void RunDoesNotContainFailedTest()
        {
            var names = new List<string>() { "fatih", "ilker", "selvi" };

            Assert.DoesNotContain(names, x => x == "ilker");
        }
    }
}
