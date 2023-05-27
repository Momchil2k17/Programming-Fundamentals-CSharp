using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string type = string.Empty;

            while (input != "END")
            {
                if (!string.IsNullOrEmpty(input))
                {
                    int tryInt;
                    double floatingPoint;
                    char character;
                    bool boolean;
                    if (int.TryParse(input,out tryInt))
                    {
                        type = "integer";
                    }
                    else if (double.TryParse(input,out floatingPoint))
                    {
                        type = "floating point";
                    }
                    else if (char.TryParse(input,out character))
                    {
                        type = "character";
                    }
                    else if (bool.TryParse(input,out boolean))
                    {
                        type = "boolean";
                    }
                    else
                    {
                        type = "string";
                    }
                    Console.WriteLine($"{input} is {type} type");
                    input = Console.ReadLine();
                }

            }
        }
    }
}
