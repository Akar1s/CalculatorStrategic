namespace Calculator
{
    public class SubtractionStrategy : ICalculationStrategy
    {
        public double Calculate(double i, double j) => i - j;
    }
}