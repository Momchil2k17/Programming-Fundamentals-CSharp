using System;
using System.Linq;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();
            foreach (var banWord in bannedWords)
            {
                while (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*',banWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
