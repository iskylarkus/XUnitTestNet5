using Xunit;
using XUnitTestNet5.App;

namespace XUnitTestNet5.Test
{
    public class EqualTest
    {
        [Fact]
        public void EqualPassedTest()
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
        public void EqualFailedTest()
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
        public void NotEqualPassedTest()
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
        public void NotEqualFailedTest()
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
