using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 0.0, width = 0.0, heigth = 0.0;
            Console.Write("Length: ");
            length= double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());
            double volume = (length*width*heigth) / 3;
            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}
