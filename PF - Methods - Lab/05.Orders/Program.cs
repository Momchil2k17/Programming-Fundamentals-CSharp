using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintPrice(product, quantity);
        }
        static void PrintPrice(string product, int quantity)
        {
            double price = 0;
            if (product=="coffee")
            {
                price = 1.5;
            }
            else if (product=="water")
            {
                price = 1;
            }
            else if (product=="coke")
            {
                price = 1.4;
            }
            else if (product=="snacks")
            {
                price = 2;
            }
            Console.WriteLine($"{price*quantity:f2}");
        }
    }
}
