namespace XUnitTestNet5.App
{
    public class CalculatorDI
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorDI(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public int Add(int a, int b)
        {
            return _calculatorService.Add(a, b);
        }

        public int Multiply(int a, int b)
        {
            return _calculatorService.Multiply(a, b);
        }
    }
}
