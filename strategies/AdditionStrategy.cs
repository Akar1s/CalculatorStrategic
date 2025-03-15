namespace Calculator
{
    public class AdditionStrategy : ICalculationStrategy
    {
        public double Calculate(double i, double j) => i + j;
    }
}
