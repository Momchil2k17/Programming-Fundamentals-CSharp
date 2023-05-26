using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            double coinsSum = 0;
            while (coins != "Start")
            {
                double addCoin = double.Parse(coins);
                if (addCoin == 0.1 || addCoin == 0.2 || addCoin == 0.5 || addCoin == 1 || addCoin == 2)
                {
                    coinsSum += addCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {addCoin:f2}");
                }
                coins = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                if (product == "Nuts")
                {
                    if (2.0 > coinsSum)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased nuts");
                        coinsSum -= 2.0;
                    }
                }
                else if (product == "Water")
                {
                    if (0.7 > coinsSum)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased water");
                        coinsSum -= 0.7;
                    }
                }
                else if(product == "Crisps")
                {
                    if (1.5 > coinsSum)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased crisps");
                        coinsSum -= 1.5;
                    }
                }
                else if(product == "Soda")
                {
                    if (0.8 > coinsSum)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased soda");
                        coinsSum -= 0.8;
                    }
                }
                else if(product == "Coke")
                {
                    if (1 > coinsSum)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased coke");
                        coinsSum -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }
            if (coinsSum <= 0)
            {
                Console.WriteLine($"Change: 0.00");
            }
            else
            {
                Console.WriteLine($"Change: {coinsSum:f2}");
            }

        }
    }
}
