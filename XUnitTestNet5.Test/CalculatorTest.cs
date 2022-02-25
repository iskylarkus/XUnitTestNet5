using Xunit;
using XUnitTestNet5.App;

namespace XUnitTestNet5.Test
{
    public class CalculatorTest
    {
        private readonly Calculator _calculator;

        public CalculatorTest()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTest()
        {
            //Arrange
            int a = 5;
            int b = 20;

            //Act
            var total = _calculator.Add(a, b);

            //Assert
            Assert.NotEqual<int>(29, total);
        }

        [Theory]
        [InlineData(1, 6, 7)]
        [InlineData(19, 11, 33)]
        [InlineData(35, 42, 77)]
        public void AddTestParam(int a, int b, int expectedTotal)
        {
            var actualTotal = _calculator.Add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(1, 6, 7)]
        [InlineData(19, 11, 33)]
        [InlineData(35, 42, 77)]
        public void Add_SimpleValues_ReturnTotalValue(int a, int b, int expectedTotal)
        {
            var actualTotal = _calculator.Add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(0, 6, 0)]
        [InlineData(19, 0, 33)]
        [InlineData(0, 42, 0)]
        public void Add_ZeroValues_ReturnZeroValue(int a, int b, int expectedTotal)
        {
            var actualTotal = _calculator.Add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        }
    }
}
