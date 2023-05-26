using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            int count = 1;
            string input = Console.ReadLine();
            while (input!=password)
            {
                if (count>=4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                count++;
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
