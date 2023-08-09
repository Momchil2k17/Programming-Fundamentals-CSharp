using System;
using System.Linq;
using System.Text;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = Console.ReadLine().Split(" ").ToArray();
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(word);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
