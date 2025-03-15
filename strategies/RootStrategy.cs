using System;

namespace Calculator
{
    public class RootStrategy : ICalculationStrategy
    {
        public double Calculate(double i, double j)
        {
            if (i < 0)
                throw new ArgumentException();
            return Math.Pow(i, 1 / j);
        }
    }
}