using System;
using System.Collections.Generic;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(' ').ToList();
            Func<string, int, bool> check = (s, n) => s.Length <= n;
            Console.WriteLine(String.Join(Environment.NewLine, names.Where(x=>check(x, n))));
        }
    }
}
