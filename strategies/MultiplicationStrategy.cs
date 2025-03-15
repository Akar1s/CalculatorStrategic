namespace Calculator
{
    public class MultiplicationStrategy : ICalculationStrategy
    {
        public double Calculate(double i, double j) => i * j;
    }
}
