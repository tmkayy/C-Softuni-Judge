using System;
using System.Collections.Generic;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> d = new Dictionary<string, List<string>>();
            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!d.ContainsKey(word))
                {
                    d.Add(word, new List<string>());
                    d[word].Add(synonym);
                }
                else
                {
                    foreach (KeyValuePair<string, List<string>> entry in d)
                    {
                        if (entry.Key == word)
                        {
                            entry.Value.Add(synonym);
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, List<string>> entry in d)
            {
                Console.WriteLine($"{entry.Key} - {string.Join(", ", entry.Value)}");
            }
        }
    }
}
