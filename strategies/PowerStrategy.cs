using System;

namespace Calculator
{
    public class PowerStrategy : ICalculationStrategy
    {
        public double Calculate(double i, double j) => Math.Pow(i, j);
    }
}