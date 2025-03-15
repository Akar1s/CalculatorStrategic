using System;

namespace Calculator
{
    public class DivisionStrategy : ICalculationStrategy
    {
        public double Calculate(double i, double j)
        {
            if (j == 0)
                throw new DivideByZeroException("Нельзя делить на ноль");
            return i / j;

        }
    }
}