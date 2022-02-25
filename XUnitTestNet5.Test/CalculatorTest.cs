using Xunit;
using XUnitTestNet5.App;

namespace XUnitTestNet5.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
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

        [Theory]
        [InlineData(1, 6, 7)]
        [InlineData(19, 11, 33)]
        [InlineData(35, 42, 77)]
        public void AddTestParam(int a, int b, int expectedTotal)
        {
            var calculator = new Calculator();

            var actualTotal = calculator.Add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        }
    }
}
