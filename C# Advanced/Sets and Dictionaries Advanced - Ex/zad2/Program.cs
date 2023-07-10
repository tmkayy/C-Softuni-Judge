using System;
using System.Collections.Generic;
using System.Linq;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            HashSet<int> h1 = new HashSet<int>(); HashSet<int> h2 = new HashSet<int>();
            for (int i = 0; i < n[0]; i++)
            {
                h1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n[1]; i++)
            {
                h2.Add(int.Parse(Console.ReadLine()));
            }
            var V = h1.Intersect(h2);
            Console.WriteLine(String.Join(" ", V));
        }
    }
}
