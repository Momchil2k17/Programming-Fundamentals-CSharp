using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            if (input >= 'A' && input <= 'Z')
            {
                Console.WriteLine($"upper-case");
            }
            else if (input >= 'a' && input <= 'z')
            {
                Console.WriteLine($"lower-case");
            }
        }
    }
}
