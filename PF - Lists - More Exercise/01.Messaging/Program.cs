using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();

            List<string> output = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int digits = numbers[i];
                int sum = 0;

                while (digits > 0)
                {
                    int currDigit = digits % 10;

                    sum += currDigit;

                    digits = digits / 10;
                }

                for (int j = 0; j < text.Length; j++)
                {
                    if (sum >= text.Length)
                    {
                        sum -= text.Length;
                    }

                    if (j == sum)
                    {
                        output.Add(text[j + i].ToString()); 
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join("", output));
        }
    }
}
