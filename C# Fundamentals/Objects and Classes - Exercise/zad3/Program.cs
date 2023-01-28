using System;
using System.Collections.Generic;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 1; i <= n; i++)
            {
                string[] article = Console.ReadLine().Split(", ");
                Article a = new Article(article[0], article[1], article[2]);
                articles.Add(a);
            }
            foreach (Article a in articles)
            {
                Console.WriteLine(a);
            }
        }
        class Article
        {
            string title;
            string content;
            string author;
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title { get => title; set => title = value; }
            public string Content { get => content; set => content = value; }
            public string Author { get => author; set => author = value; }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
