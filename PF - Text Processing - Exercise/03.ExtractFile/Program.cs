using System;
using System.Linq;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split("\\").ToArray();
            string lastWords = words[words.Length - 1];
            string fileName = lastWords.Substring(0, lastWords.IndexOf("."));
            string fileExtension = lastWords.Substring(lastWords.IndexOf(".")+1);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
