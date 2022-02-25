using System.Collections.Generic;
using Xunit;

namespace XUnitTestNet5.Test
{
    public class IsAssignableFromTest
    {
        [Fact]
        public void IsAssignableFromPassedTest()
        {
            Assert.IsAssignableFrom<object>("ilker");
        }

        [Fact]
        public void IsAssignableFromFailedTest()
        {
            Assert.IsAssignableFrom<int>(new object());
        }

        [Fact]
        public void GenericIsAssignableFromPassedTest()
        {
            Assert.IsAssignableFrom<IEnumerable<string>>(new List<string>());
        }

        [Fact]
        public void GenericIsAssignableFromFailedTest()
        {
            Assert.IsAssignableFrom<IEnumerable<string>>(new List<int>());
        }
    }
}
