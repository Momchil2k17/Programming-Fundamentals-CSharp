using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string method = Console.ReadLine();
            if (method=="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a,b));
            }
            else if (method=="char")
            {
                char a =char.Parse(Console.ReadLine());
                char b =char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a,b));
            }
            else if (method=="string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a, b));
            }
        }
        static int GetMax(int a,int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static char GetMax(char a, char b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b)>0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
