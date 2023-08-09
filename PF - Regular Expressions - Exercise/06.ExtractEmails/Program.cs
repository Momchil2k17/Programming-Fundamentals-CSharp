using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Za-z0-9._-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";
            string input = Console.ReadLine();
            foreach (Match match in Regex.Matches(input,pattern))
            {
                Console.WriteLine(match);
            }
        }
    }
}
