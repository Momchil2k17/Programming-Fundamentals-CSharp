using System;
using System.Collections.Generic;

namespace _05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            var comments = new List<string>();

            string comment = Console.ReadLine();

            while (comment != "end of comments")
            {
                comments.Add(comment);

                comment = Console.ReadLine();
            }

        
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");

            
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");

         
            foreach (var comm in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comm}");
                Console.WriteLine("</div>");
            }
        }
    }
}
