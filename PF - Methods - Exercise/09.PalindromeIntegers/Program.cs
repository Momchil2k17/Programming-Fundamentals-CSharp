using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Palindrome(a);
        }
        static void Palindrome(string a)
        {
            while (a!="END")
            {
                string reversed = "";
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    reversed += a[i];
                }
                if (reversed==a)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                a = Console.ReadLine();
            }
        }
    }
}
