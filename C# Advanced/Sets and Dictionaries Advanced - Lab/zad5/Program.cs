using System;
using System.Collections.Generic;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> ne6ta = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (!ne6ta.ContainsKey(s[0]))
                {
                    Dictionary<string, List<string>> lol = new Dictionary<string, List<string>>();
                    lol.Add(s[1], new List<string> { s[2] });
                    ne6ta.Add(s[0], lol);
                }
                else
                {
                    if (ne6ta[s[0]].ContainsKey(s[1]))
                    {
                        ne6ta[s[0]][s[1]].Add(s[2]);
                    }
                    else
                    {
                        ne6ta[s[0]].Add(s[1], new List<string> { s[2] });
                    }
                }
            }
            foreach (var item in ne6ta)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($" {item2.Key} -> {String.Join(", ", item2.Value)}");
                }
            }
        }
    }
}
