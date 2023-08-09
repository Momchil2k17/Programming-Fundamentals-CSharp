using System;

namespace _02.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Closer(x1, y1, x2, y2);
        }
        static void Closer(double x1, double y1, double x2, double y2)
        {
            double area1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double area2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (area1 < area2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (area2 < area1)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
