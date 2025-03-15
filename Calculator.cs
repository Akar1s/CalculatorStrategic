using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Calculator
    {
        private readonly Dictionary<string, ICalculationStrategy> _strategies;

        public Calculator()
        {
                _strategies = new Dictionary<string, ICalculationStrategy>
            {
                { "+", new AdditionStrategy() },
                { "-", new SubtractionStrategy() },
                { "*", new MultiplicationStrategy() },
                { "/", new DivisionStrategy() },
                { "%", new ModulusStrategy() },
                { "^", new PowerStrategy() },
                { "√", new RootStrategy() }
            };
        }

        public double Execute(string operation, double a, double b)
        {
            if (!_strategies.ContainsKey(operation))
                throw new InvalidOperationException($"Операция '{operation}' не поддерживается");

            return _strategies[operation].Calculate(a, b);
        }
    }
}