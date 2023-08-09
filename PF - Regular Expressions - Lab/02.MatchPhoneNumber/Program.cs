using System;
using System.Linq;
using System.Text.RegularExpressions;
/*+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222
*/

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359 2 \d{3} \d{4})|(\+359-2-\d{3}-\d{4}\b)";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input,pattern);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
