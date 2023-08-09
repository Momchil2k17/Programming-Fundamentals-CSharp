using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            PrintCount(word);
        }
        static void PrintCount(string word)
        {
            int vowelCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]=='e' || word[i]=='o' || word[i] == 'i' || word[i] == 'u' || word[i] == 'a')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);
        }
    }
}
