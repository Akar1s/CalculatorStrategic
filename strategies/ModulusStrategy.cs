namespace Calculator
{
    public class ModulusStrategy : ICalculationStrategy
    {
        public double Calculate(double i, double j) => i % j;
    }
}
