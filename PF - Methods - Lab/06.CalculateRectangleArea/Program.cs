using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateArea(a,b));
        }
        static double CalculateArea(double a,double b)
        {
            return a * b;
        }
    }
}
