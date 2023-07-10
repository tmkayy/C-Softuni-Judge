using System;
using System.Collections.Generic;
using System.Linq;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> stuudents = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (!stuudents.ContainsKey(s[0]))
                {
                    stuudents.Add(s[0], new List<decimal> { decimal.Parse(s[1]) });
                }
                else
                {
                    stuudents[s[0]].Add(decimal.Parse(s[1]));
                }
            }
            foreach (var item in stuudents)
            {
                string a = null;
                foreach (var item2 in item.Value)
                {
                    a += $"{item2:f2} ";
                }
                Console.WriteLine($"{item.Key} -> {a}(avg: {item.Value.Average():f2})");
            }
        }
    }
}
