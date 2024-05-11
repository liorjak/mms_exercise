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

            Console.WriteLine($"The Number is {numericalExpression.ToString()} ");

            Console.WriteLine(numericalExpression.GetValue(number));
        }
    }
}
