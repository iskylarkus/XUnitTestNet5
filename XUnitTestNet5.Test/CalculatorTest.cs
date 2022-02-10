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
            Assert.Equal<int>(25, total);
        }
    }
}
