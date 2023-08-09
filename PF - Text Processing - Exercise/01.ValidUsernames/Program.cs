using System;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ").ToArray();
            foreach (var username in usernames)
            {
                bool isValid = false;
                if (username.Length>3 && username.Length<16)
                {
                    isValid = username.All(character => char.IsLetterOrDigit(character) || character =='-' || character == '_');
                }
                if (isValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
