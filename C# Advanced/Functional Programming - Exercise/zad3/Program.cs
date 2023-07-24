using System;
using System.Collections.Generic;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Func<int[], int> min = (n) => n.Min();
            Console.WriteLine(min(n));
        }
    }
}
