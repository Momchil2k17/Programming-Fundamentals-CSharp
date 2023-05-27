using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string decrypted = string.Empty;
            for (int i = 0; i < lines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                decrypted += (char)(symbol + key);
            }
            Console.WriteLine(decrypted);
        }
    }
}
