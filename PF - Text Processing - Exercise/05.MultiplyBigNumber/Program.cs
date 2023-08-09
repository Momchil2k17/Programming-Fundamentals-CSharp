using System;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            if (secondNum==0)
            {
                Console.WriteLine(0);
                return;
            }
            int numToAdd = 0;
            string result="";
            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int currNum = int.Parse(firstNum[i].ToString());
                int multiply = currNum * secondNum+numToAdd;
                numToAdd = 0;
                if (multiply>=10)
                {
                    numToAdd = multiply / 10;
                    result += multiply % 10;
                }
                else
                {
                    result += multiply % 10;
                }
                if (i==0 && numToAdd!=0)
                {
                    result += numToAdd;
                }
            }
            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
        }
    }
}
