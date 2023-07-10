using System;
using System.Collections.Generic;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> h = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                List<string> z = Console.ReadLine().Split(' ').ToList();
                z.ForEach(x=>h.Add(x));
            }
            Console.WriteLine(String.Join(" ", h.OrderBy(x=>x)));
        }
    }
}
