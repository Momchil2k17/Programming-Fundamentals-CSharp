using System;
using System.Text.RegularExpressions;

namespace _02.BossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\|(?<name>[A-Z]{4,})\|\:\#(?<title>[A-Za-z]+\s[A-Za-z]+)\#";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, pattern))
                {
                    string boss = "";
                    string title = "";
                    foreach (Match match in Regex.Matches(input, pattern))
                    {
                        boss = match.Groups["name"].Value;
                        title = match.Groups["title"].Value;
                    }
                    Console.WriteLine($"{boss}, The {title}");
                    Console.WriteLine($">> Strength: {boss.Length}");
                    Console.WriteLine($">> Armor: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
