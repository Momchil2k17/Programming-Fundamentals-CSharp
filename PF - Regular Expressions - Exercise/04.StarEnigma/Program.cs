using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string countPattern = @"[SsTtAaRr]";
            string pattern = @"\@(?<planet>[A-Z][a-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*\!(?<attack>[AD])![^@\-!:>]*->(?<soldier>\d+)";
            int count = 0;
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                foreach (Match match in Regex.Matches(input,countPattern))
                {
                    count++;
                }
                string encryptedText = "";
                for (int j = 0; j < input.Length; j++)
                {
                   encryptedText+=(char)(input[j]-count);
                }
                foreach (Match match in Regex.Matches(encryptedText, pattern))
                {
                    if (match.Groups["attack"].Value =="A")
                    {
                        attacked.Add(match.Groups["planet"].Value);
                    }
                    else
                    {
                        destroyed.Add(match.Groups["planet"].Value);
                    }
                }
                count = 0;
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            attacked.Sort();
            foreach (var planet in attacked)
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            destroyed.Sort();
            foreach (var planet in destroyed)
            {
                Console.WriteLine($"-> {planet}");
            }

        }
    }
}
