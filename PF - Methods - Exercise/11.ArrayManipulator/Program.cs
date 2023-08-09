using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Calculate(command, arr);
        }
        static void Calculate(string command, int[] arr)
        {
            while (command != "end")
            {
                string[] info = command.Split(' ').ToArray();
                if (info[0] == "exchange")
                {
                    Exchange(int.Parse(info[1]), arr);
                }
                else if (info[0] == "max")
                {
                    if (info[1] == "even")
                    {
                        MaxEven(arr);
                    }
                    else
                    {
                        MaxOdd(arr);
                    }
                }
                else if (info[0] == "min")
                {
                    if (info[1] == "even")
                    {
                        MinEven(arr);
                    }
                    else if(info[1] == "odd")
                    {
                        MinOdd(arr);
                    }
                }
                else if (info[0] == "first")
                {
                    if (info[2] == "even")
                    {
                        FirstEven(int.Parse(info[1]), arr);
                    }
                    else if(info[2] == "odd")
                    {
                        FirstOdd(int.Parse(info[1]), arr);
                    }
                }
                else if (info[0]=="last")
                {
                    if (info[2] == "even")
                    {
                        LastEven(int.Parse(info[1]), arr);
                    }
                    else if (info[2] == "odd")
                    {
                        LastOdd(int.Parse(info[1]), arr);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        static void LastOdd(int count, int[] arr)
        {
            if (count > arr.Count() || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int evenCount = 0;
                for (int i = 0; i < arr.Count(); i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        evenCount++;
                    }
                }
                if (evenCount == 0)
                {
                    Console.WriteLine("[]");

                }
                else
                {
                    int currentCount = 0;
                    int smallerCount = 0;
                    if (count > evenCount)
                    {
                        smallerCount = evenCount;
                    }
                    else
                    {
                        smallerCount = count;
                    }
                    int[] even = new int[smallerCount];
                    for (int i = arr.Count() - 1; i >= 0; i--)
                    {
                        if (arr[i] % 2 != 0 && currentCount < smallerCount)
                        {
                            even[currentCount] = arr[i];
                            currentCount++;
                        }
                    }
                    Console.WriteLine($"[{string.Join(", ", even)}]");
                }
            }
        }

        static void LastEven(int count, int[] arr)
        {
            if (count > arr.Count() || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int evenCount = 0;
                for (int i = 0; i < arr.Count(); i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenCount++;
                    }
                }
                if (evenCount == 0)
                {
                    Console.WriteLine("[]");

                }
                else
                {
                    int currentCount = 0;
                    int smallerCount = 0;
                    if (count > evenCount)
                    {
                        smallerCount = evenCount;
                    }
                    else
                    {
                        smallerCount = count;
                    }
                    int[] even = new int[smallerCount];
                    for (int i = arr.Count() - 1; i >= 0; i--)
                    {
                        if (arr[i] % 2 == 0 && currentCount < smallerCount)
                        {
                            even[currentCount] = arr[i];
                            currentCount++;
                        }
                    }
                    Console.WriteLine($"[{string.Join(", ", even)}]");
                }
            }
        }

        static void FirstEven(int count, int[] arr)
        {
            if (count > arr.Count() || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int evenCount = 0;
                for (int i = 0; i < arr.Count(); i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenCount++;
                    }
                }
                if (evenCount == 0)
                {
                    Console.WriteLine("[]");

                }
                else
                {
                    int currentCount = 0;
                    int smallerCount = 0;
                    if (count > evenCount)
                    {
                        smallerCount = evenCount;
                    }
                    else
                    {
                        smallerCount = count;
                    }
                    int[] even = new int[smallerCount];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0 && currentCount < smallerCount)
                        {
                            even[currentCount] = arr[i];
                            currentCount++;
                        }
                    }
                    Console.WriteLine($"[{string.Join(", ", even)}]");
                }
            }
        }

        static void FirstOdd(int count, int[] arr)
        {
            if (count > arr.Count() || count<0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int evenCount = 0;
                for (int i = 0; i < arr.Count(); i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        evenCount++;
                    }
                }
                if (evenCount == 0)
                {
                    Console.WriteLine("[]");

                }
                else
                {
                    int currentCount = 0;
                    int smallerCount = 0;
                    if (count>evenCount)
                    {
                        smallerCount = evenCount;
                    }
                    else
                    {
                        smallerCount = count;
                    }
                    int[] even = new int[smallerCount];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 != 0 && currentCount<smallerCount)
                        {
                            even[currentCount] = arr[i];
                            currentCount++;
                        }
                    }
                    Console.WriteLine($"[{string.Join(", ",even)}]");
                }


            }
        }

        static void MinEven(int[] arr)
        {
            bool hasOdd = false;
            int index = 0;
            int minOdd = int.MaxValue;
            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] % 2 == 0 && arr[i] < minOdd)
                {
                    minOdd = arr[i];
                    index = i;
                    hasOdd = true;
                }
            }
            if (hasOdd)
                Console.WriteLine(index);
            else
                Console.WriteLine("No matches");
        }

        static void MinOdd(int[] arr)
        {
            bool hasEven = false;
            int index = 0;
            int minEven = int.MaxValue;
            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] % 2 != 0 && arr[i] < minEven)
                {
                    minEven = arr[i];
                    index = i;
                    hasEven = true;
                }
            }
            if (hasEven)
                Console.WriteLine(index);
            else
                Console.WriteLine("No matches");
        }

        static void MaxEven(int[] arr)
        {
            bool hasOdd = false;
            int maxOdd = int.MinValue;
            int index = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] % 2 == 0 && arr[i] > maxOdd)
                {
                    maxOdd = arr[i];
                    index = i;
                    hasOdd = true;
                }
            }
            if (hasOdd)
                Console.WriteLine(index);
            else
                Console.WriteLine("No matches");

        }

        static void MaxOdd(int[] arr)
        {
            bool hasEven = false;
            int index = 0;
            int maxEven = int.MinValue;
            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] % 2 != 0 && arr[i] > maxEven)
                {
                    maxEven = arr[i];
                    index = i;
                    hasEven = true;
                }
            }
            if (hasEven)
                Console.WriteLine(index);
            else
                Console.WriteLine("No matches");
        }

        static void Exchange(int index, int[] arr)
        {
            if (index < 0 || index > arr.Count() - 1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                int[] newArr = new int[arr.Count()];
                for (int i = 0; i < arr.Count() - index - 1; i++)
                {
                    newArr[i] = arr[index + i + 1];
                }
                for (int i = arr.Count() - index - 1; i < arr.Count(); i++)
                {
                    newArr[i] = arr[i + index + 1 - arr.Count()];
                }
                for (int i = 0; i < arr.Count(); i++)
                {
                    arr[i] = newArr[i];
                }
            }
        }
    }
}
