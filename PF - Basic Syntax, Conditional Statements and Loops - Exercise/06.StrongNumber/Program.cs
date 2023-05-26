using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputNum = int.Parse(input);
            int facNum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int num = int.Parse($"{input[i]}");
                if (num==0)
                {
                    facNum+=1;
                    continue;
                }
                int currSum=1;
                for (int j = 1; j <=num; j++)
                {
                    currSum*=j;
                }
                facNum += currSum;
            }
            if (facNum==inputNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
