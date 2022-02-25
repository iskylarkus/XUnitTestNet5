using Moq;
using System;
using Xunit;
using XUnitTestNet5.App;

namespace XUnitTestNet5.Test
{
    public class CalculatorDITest
    {
        private readonly CalculatorDI _calculator;
        private readonly Mock<ICalculatorService> _mock;

        public CalculatorDITest()
        {
            _mock = new Mock<ICalculatorService>();

            _calculator = new CalculatorDI(_mock.Object);
            //_calculator = new CalculatorDI(new CalculatorService());
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
            _mock.Setup(x => x.Add(a,b)).Returns(expectedTotal);

            var actualTotal = _calculator.Add(a, b);

            Assert.Equal(expectedTotal, actualTotal);

            _mock.Verify(x => x.Add(a,b), Times.Once);
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

        [Theory]
        [InlineData(19, 11, 33)]
        public void Multiply_SimpleValues_ReturnMultipliedValue(int a, int b, int expectedMultiplied)
        {
            _mock.Setup(x => x.Multiply(a, b)).Returns(expectedMultiplied);

            var actualMultiply = _calculator.Multiply(a, b);

            Assert.Equal(expectedMultiplied, actualMultiply);
        }

        [Theory]
        [InlineData(0, 35)]
        public void Multiply_ZeroValue_ReturnException(int a, int b)
        {
            string error = "a=0 olamaz..!";

            _mock.Setup(x => x.Multiply(a, b)).Throws(new Exception(error));

            Exception exception = Assert.Throws<Exception>(() => _calculator.Multiply(a, b));

            Assert.Equal(error, exception.Message);
        }

        [Theory]
        [InlineData(19, 11, 209)]
        public void Multiply_CallbackValues_ReturnMultipliedValue(int a, int b, int expectedMultiplied)
        {
            int actualMultiply = 0;

            _mock.Setup(x => x.Multiply(It.IsAny<int>(), It.IsAny<int>())).Callback<int, int>((x, y) => actualMultiply = x * y);

            _calculator.Multiply(a, b);
            Assert.Equal(expectedMultiplied, actualMultiply);

            _calculator.Multiply(5, 20);
            Assert.Equal(100, actualMultiply);
        }
    }
}
