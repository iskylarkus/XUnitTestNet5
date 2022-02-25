using System.Collections.Generic;
using Xunit;

namespace XUnitTestNet5.Test
{
    public class ContainTest
    {
        [Fact]
        public void ContainPassedTest()
        {
            //Assert
            Assert.Contains("ilker", "ilker selvi");
        }

        [Fact]
        public void ContainFailedTest()
        {
            //Assert
            Assert.Contains("fatih", "ilker selvi");
        }

        [Fact]
        public void DoesNotContainPassedTest()
        {
            var names = new List<string>() { "fatih", "ilker", "selvi" };

            Assert.DoesNotContain(names, x => x == "emin");
        }

        [Fact]
        public void DoesNotContainFailedTest()
        {
            var names = new List<string>() { "fatih", "ilker", "selvi" };

            Assert.DoesNotContain(names, x => x == "ilker");
        }
    }
}
