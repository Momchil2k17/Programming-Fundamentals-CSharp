using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            sbyte leftCount = 0;
            sbyte rightCount = 0;
            for (int i = 0; i < n; i++) 
            {
                string input = Console.ReadLine();
                if (input=="(")
                {
                    leftCount++;
                    if (leftCount-rightCount!=1)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                else if (input==")")
                {
                    rightCount ++;
                    if (leftCount - rightCount != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            if (leftCount==rightCount)
                Console.WriteLine("BALANCED");
            else
                Console.WriteLine("UNBALANCED");
        }
    }
}
