using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double l = Math.Ceiling(studentCount * 1.1) * lightPrice;
            double r = robePrice * studentCount;
            double b = (studentCount - studentCount / 6) * beltPrice;

            double neededMoney = l+r+b;

            if (money >= neededMoney)
            { 
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(money - neededMoney):f2}lv more.");
            }

        }
    }
}
