using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            Longer(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void Longer(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double line1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double line2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            if (line1 > line2)
            {
                Closer(x1, y1, x2, y2);
            }
            else if (line1 < line2)
            {
                Closer(x3, y3, x4, y4);
            }
            else
            {
                Closer(x1, y1, x2, y2);
            }
        }
        static void Closer(double x1, double y1, double x2, double y2)
        {
            double area1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double area2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (area1 < area2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else if (area2 < area1)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }
    }
}
