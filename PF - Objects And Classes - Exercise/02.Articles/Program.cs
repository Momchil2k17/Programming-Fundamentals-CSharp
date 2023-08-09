using System;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(info[0], info[1], info[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                if (command.Substring(0, 4) == "Edit")
                {
                    article.Content = article.Edit(command.Substring(6, command.Length - 6));
                }
                else if (command.Substring(0, 12) == "ChangeAuthor")
                {
                    article.Author = article.ChangeAuthor(command.Substring(14, command.Length - 14));
                }
                else if (command.Substring(0, 6) == "Rename")
                {
                    article.Title = article.Rename(command.Substring(8, command.Length - 8));
                }
            }
            Console.WriteLine(article.ToString());
            
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Edit(string v)
        {
            return v;
        }
        public string ChangeAuthor(string v)
        {
            return v;
        }
        public string Rename(string v)
        {
            return v;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";

        }
    }
}
