using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            bool oneOperation = false;
            if (oneOperation)
            {
                Console.WriteLine("Введите выражение в формате 'число оператор число':");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');

                if (parts.Length != 3 ||
                    !double.TryParse(parts[0], out double a) ||
                    !double.TryParse(parts[2], out double b))
                {
                    Console.WriteLine("Ошибка: Некорректный ввод.");
                    return;
                }

                Calculator calculator = new Calculator();

                try
                {
                    double result = calculator.Execute(parts[1], a, b);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            ExpressionEvaluator evaluator = new ExpressionEvaluator();

            Console.WriteLine("Введите математическое выражение:");
            string inputt = Console.ReadLine();

            try
            {
                double result = evaluator.Evaluate(inputt);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}