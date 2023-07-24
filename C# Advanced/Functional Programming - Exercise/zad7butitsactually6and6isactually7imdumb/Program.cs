using System;
using System.Collections.Generic;
using System.Linq;

namespace zad7butitsactually6and6isactually7imdumb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> names = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            Func<int, int, bool> div = (a, b) => a % b != 0;
            names.Reverse();
            Console.WriteLine(String.Join(" ", names.Where(x=>div(x, n))));
        }
    }
}
