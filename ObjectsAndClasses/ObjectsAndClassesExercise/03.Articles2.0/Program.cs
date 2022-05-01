using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2_0
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> listOfArticles = new List<Article>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Article article = new Article(input[0], input[1], input[2]);
                listOfArticles.Add(article);
            }
            string criteria = Console.ReadLine();
            var orderedList = new List<Article>();
            if (criteria == "title")
            {
                orderedList = listOfArticles.OrderBy(x => x.Title).ToList();
            }
            else if (criteria == "content")
            {
                orderedList = listOfArticles.OrderBy(x => x.Content).ToList();
            }
            else if (criteria == "author")
            {
                orderedList = listOfArticles.OrderBy(x => x.Author).ToList();
            }
            foreach (var item in orderedList)
            {
                Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
            }
        }
    }
}
