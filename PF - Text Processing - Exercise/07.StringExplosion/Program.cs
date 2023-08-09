using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder bombedStr = new StringBuilder();
            int strength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    bombedStr.Append(input[i]);
                    strength += int.Parse(input[i + 1].ToString());
                    continue;
                }
                if (strength > 0)
                {
                    strength--;
                }
                else
                {
                    bombedStr.Append(input[i]);
                }
            }
            Console.WriteLine(bombedStr);
        }
    }
}
