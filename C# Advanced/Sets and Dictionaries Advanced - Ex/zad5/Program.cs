using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Dictionary<char, int> d = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (d.ContainsKey(s[i]))
                {
                    d[s[i]]++;
                }
                else
                {
                    d.Add(s[i], 1);
                }
            }
            foreach (var item in d.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
