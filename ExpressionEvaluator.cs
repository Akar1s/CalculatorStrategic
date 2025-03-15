using System;
using System.Globalization;

namespace Calculator
{
    public class ExpressionEvaluator
    {
        private string _expression;
        private int _index;

        public double Evaluate(string expression)
        {
            _expression = expression.Replace(" ", "");
            _index = 0;
            return AdditionSubtractionTurn();
        }

        private double AdditionSubtractionTurn()
        {
            double result = MultiplicationDivisionTurn();
            while (_index < _expression.Length && (_expression[_index] == '+' || _expression[_index] == '-'))
            {
                char op = _expression[_index++];
                double nextTerm = MultiplicationDivisionTurn();
                result = op == '+' ? result + nextTerm : result - nextTerm;
            }
            return result;
        }

        private double MultiplicationDivisionTurn()
        {
            double result = PowerTurn();
            while (_index < _expression.Length && (_expression[_index] == '*' || _expression[_index] == '/' || _expression[_index] == '%'))
            {
                char op = _expression[_index++];
                double nextFactor = PowerTurn();
                result = op == '*' ? result * nextFactor : op == '/' ? result / nextFactor : result % nextFactor;
            }
            return result;
        }

        private double PowerTurn()
        {
            double result = UnaryParenthesesTurn();
            while (_index < _expression.Length && _expression[_index] == '^')
            {
                _index++;
                result = Math.Pow(result, PowerTurn());
            }
            return result;
        }

        private double UnaryParenthesesTurn()
        {
            if (_index < _expression.Length && _expression[_index] == '-')
            {
                _index++;
                return -UnaryParenthesesTurn();
            }
            if (_expression[_index] == '(')
            {
                _index++;
                double value = AdditionSubtractionTurn();
                _index++;
                return value;
            }
            return NumberTurn();
        }

        private double NumberTurn()
        {
            int start = _index;
            while (_index < _expression.Length && (char.IsDigit(_expression[_index]) || _expression[_index] == '.'))
            {
                _index++;
            }
            string numberStr = _expression.Substring(start, _index - start);
            if (!double.TryParse(numberStr, NumberStyles.Float, CultureInfo.InvariantCulture, out double result))
                throw new ArgumentException();
            return result;
        }
    }
}