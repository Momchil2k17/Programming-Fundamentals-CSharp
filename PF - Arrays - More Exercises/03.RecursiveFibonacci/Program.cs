using System;

namespace _03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int wantedNum = int.Parse(Console.ReadLine());

            if (wantedNum == 1) 
            {
                Console.WriteLine(1);
                return;
            }
            if (wantedNum == 2) 
            {
                Console.WriteLine(1);
                return;
            }

            int[] output = new int[2]; 

            while (true)
            {
                output[0] = 1;
                output[1] = 1; 

                for (int i = 2; i < output.Length; i++) 
                {
                    output[i] = output[i - 1] + output[i - 2];
                    if (i + 1 == wantedNum) 
                    {
                        Console.WriteLine(output[i]);
                        return;
                    }

                }
                output = new int[output.Length + 1];
            }
        }
    }
}
