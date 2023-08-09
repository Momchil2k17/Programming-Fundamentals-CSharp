using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CheckPassword(password);
        }
        static void CheckPassword(string password)
        {
            bool isValid = true;
            int digitCount = 0;
            if (password.Length < 6 || password.Length>10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetterOrDigit(password[i])==false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                    break;
                }
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digitCount++;
                }
            }
            if (digitCount<2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
