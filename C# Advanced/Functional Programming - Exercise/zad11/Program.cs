using System;
using System.Collections.Generic;
using System.Linq;

namespace zad11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> IOFFJDFJUSODFSFU = Console.ReadLine().Split(' ').ToList();
            Func<string, int, bool> first = (s, n) => s.Sum(x=>x) >= n;
            Action<List<string>, int, Func<string, int, bool>> second = (s, n, f) =>
            {
                Console.WriteLine(String.Join(" ", s.First(x=>f(x,n))));
            };
            second(IOFFJDFJUSODFSFU, n, first);
        }
    }
}
