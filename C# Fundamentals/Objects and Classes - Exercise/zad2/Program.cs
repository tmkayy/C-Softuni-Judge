using System;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ");
            Article a = new Article(article[0], article[1], article[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                switch (command[0])
                {
                    case "Edit":
                        a.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        a.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        a.Rename(command[1]);
                        break;
                }
            }
            Console.WriteLine(a);
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
            public void Edit(string newContent)
            {
                this.Content= newContent;
            }
            public void ChangeAuthor (string newAuthor)
            {
                this.Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                this.Title = newTitle;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
