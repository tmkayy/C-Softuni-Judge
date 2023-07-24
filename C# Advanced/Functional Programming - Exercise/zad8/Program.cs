using System;
using System.Collections.Generic;
using System.Linq;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Func<int, List<int>, bool> div = (a, l) =>
            {
                for (int i = 0; i < l.Count; i++)
                {
                    if (a % l[i] != 0)
                        return false;
                } return true;
            };
            for (int i = 1; i <= n; i++)
            {
                if (div(i, list))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
