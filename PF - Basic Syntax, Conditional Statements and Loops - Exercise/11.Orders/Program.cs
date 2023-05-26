using System;

namespace _11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orderCount = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < orderCount; i++)
            {
                double orderPrice = 0;
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                orderPrice = ((days * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                total += orderPrice;
            }
            Console.WriteLine($"Total: ${total:F2}");

        }
    }
}
