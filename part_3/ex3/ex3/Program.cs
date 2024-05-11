using System;
using ex3;

namespace ex3
{
    class Program
    {
        public static void Main(String[] args)
        {
            long number = 123;
            NumericalExpression numericalExpression = new NumericalExpression(number);

            Console.WriteLine($"The number of letters in the number '{numericalExpression.ToString()}' " +
                $"|{ numericalExpression.GetValue(number)}| is " +
                $"'{NumericalExpression.SumLetters(number)}'");
        }
    }
}
