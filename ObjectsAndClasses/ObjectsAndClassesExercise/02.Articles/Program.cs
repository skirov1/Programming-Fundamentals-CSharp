using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(": ",StringSplitOptions.RemoveEmptyEntries);
                if (cmd[0] == "Edit")
                {
                    article.Edit(cmd[1]);
                }
                else if (cmd[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(cmd[1]);
                }
                else if (cmd[0] == "Rename")
                {
                    article.Rename(cmd[1]);
                }
            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
