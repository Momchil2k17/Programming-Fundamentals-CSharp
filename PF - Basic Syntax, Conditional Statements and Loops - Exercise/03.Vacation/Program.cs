using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double totalPrice = 0;
            double ticketPrice = 0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    ticketPrice=8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    ticketPrice = 9.8;
                }
                else if (dayOfWeek == "Sunday")
                {
                    ticketPrice = 10.46;
                }
                if (peopleCount>=30)
                {
                    totalPrice = ticketPrice*peopleCount*0.85;
                }
                else
                {
                    totalPrice = ticketPrice * peopleCount;
                }
            }
            else if (groupType=="Business")
            {
                if (dayOfWeek == "Friday")
                {
                    ticketPrice = 10.9;
                }
                else if (dayOfWeek == "Saturday")
                {
                    ticketPrice = 15.6;
                }
                else if (dayOfWeek == "Sunday")
                {
                    ticketPrice = 16;
                }
                if (peopleCount>=100)
                {
                    totalPrice=(peopleCount-10)*ticketPrice;
                }
                else
                {
                    totalPrice = peopleCount * ticketPrice;
                }
            }
            else if (groupType=="Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    ticketPrice = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    ticketPrice = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    ticketPrice = 22.5;
                }
                if (peopleCount>=10 && peopleCount<=20)
                {
                    totalPrice = ticketPrice * peopleCount * 0.95;
                }
                else
                {
                    totalPrice = ticketPrice * peopleCount;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
