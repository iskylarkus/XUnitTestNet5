using Xunit;
using XUnitTestNet5.App;

namespace XUnitTestNet5.Test
{
    public class EqualTest
    {
        [Fact]
        public void RunEqualPassedTest()
        {
            //Arrange
            int a = 5;
            int b = 20;
            var calculator = new Calculator();

            //Act
            var total = calculator.Add(a, b);

            //Assert
            Assert.Equal<int>(25, total);
        }

        [Fact]
        public void RunEqualFailedTest()
        {
            //Arrange
            int a = 5;
            int b = 20;
            var calculator = new Calculator();

            //Act
            var total = calculator.Add(a, b);

            //Assert
            Assert.Equal<int>(29, total);
        }

        [Fact]
        public void RunNotEqualPassedTest()
        {
            //Arrange
            int a = 5;
            int b = 20;
            var calculator = new Calculator();

            //Act
            var total = calculator.Add(a, b);

            //Assert
            Assert.NotEqual<int>(29, total);
        }

        [Fact]
        public void RunNotEqualFailedTest()
        {
            //Arrange
            int a = 5;
            int b = 20;
            var calculator = new Calculator();

            //Act
            var total = calculator.Add(a, b);

            //Assert
            Assert.NotEqual<int>(25, total);
        }
    }
}
