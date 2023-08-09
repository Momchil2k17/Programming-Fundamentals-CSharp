using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string znak= Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(a,znak,b));
        }
        static double Calculate(double a,string znak,double b)
        {
            double result = 0;
            if (znak=="/")
            {
                result = a / b;
            }
            else if (znak=="*")
            {
                result = a * b;
            }
            else if (znak=="+")
            {
                result = a + b;
            }
            else if (znak=="-")
            {
                result = a - b;
            }
            return result;
        }
    }
}
