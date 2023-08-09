using System;

namespace _05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        { 
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine(CheckMultiplicationSign(num1, num2, num3));
        }
        static string CheckMultiplicationSign(double num1, double num2, double num3)
        {
            string sign = "";
            if (num1 < 0 && num2 < 0 && num3 < 0)
                sign = "negative";

            else if (num1 > 0 && num2 > 0 && num3 > 0)
                sign = "positive";

            else if (num1 == 0 || num2 == 0 || num3 == 0)
                sign = "zero";

            else if (num1 > 0)
            {
                if (num2 < 0 && num3 < 0)
                    sign = "positive";

                else
                    sign = "negative";
            }

            else if (num1 < 0)
            {
                if (num2 > 0 && num3 > 0)
                    sign = "negative";

                else
                    sign = "positive";
            }

            return sign;
        }
    }
}
