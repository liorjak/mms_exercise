using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ex3;


namespace ex3
{
    class NumericalExpression
    {
        public long Number { get; set; }

        public const long LIMIT = 1000000000000;

        public NumericalExpression(long number)
        {
            Number = number;
        }

        public override string ToString()
        {
            long limit;
            long curr_hun;
            int count;

            limit = LIMIT;
            count = 0;

            if (Number == 0)
            {
                return ("Zero");
            }

            string[] multiplier = {
                "",        "Trillion", "Billion",
                "Million", "Thousand"
            };

            string[] first_twenty = {
                "",        "One",       "Two",      "Three",
                "Four",    "Five",      "Six",      "Seven",
                "Eight",   "Nine",      "Ten",      "Eleven",
                "Twelve",  "Thirteen",  "Fourteen", "Fifteen",
                "Sixteen", "Seventeen", "Eighteen", "Nineteen"
            };

            string[] tens = {
                "",        "Twenty", "Thirty",
                "Forty",   "Fifty",  "Sixty",
                "Seventy", "Eighty", "Ninety"
            };

            if (Number < 20)
            {
                return first_twenty[(int)Number];
            }

            string answer = "";

            for (long i = Number; i > 0; i %= limit, limit /= 1000)
            {
                curr_hun = i / limit;

                while (curr_hun == 0)
                {
                    i %= limit;
                    limit /= 1000;

                    curr_hun = i / limit;
                    ++count;
                }

                if (curr_hun > 99)
                {
                    answer += $"{first_twenty[(int)curr_hun / 100]} Hundred ";
                }

                curr_hun %= 100;

                if (curr_hun > 0 && curr_hun < 20)
                {
                    answer += $"{first_twenty[(int)curr_hun]} ";
                }
                else if (curr_hun % 10 == 0 && curr_hun != 0)
                {
                    answer += $"{tens[((int)curr_hun / 10) - 1]} ";
                }
                else if (curr_hun > 20 && curr_hun < 100)
                {
                    answer += $"{tens[((int)curr_hun / 10) - 1]} {first_twenty[(int)curr_hun % 10]} ";
                }

                if (count < 4)
                {
                    answer += $"{multiplier[++count]} ";
                }
            }
            return answer;
        }

        public long GetValue(long number)
        {
            return number;
        }

        public static int SumLetters(long number)
        {
            NumericalExpression numericalExpression = new NumericalExpression(number);
            string words = numericalExpression.ToString().Replace(" ", "");
            return words.Length;
        }

        // The principle in OOP is polymorphism (ex 7f)
        public static int SumLetters(NumericalExpression numericalExpression)
        {
            string words = numericalExpression.ToString().Replace(" ", "");
            return words.Length;
        }
    }
}

