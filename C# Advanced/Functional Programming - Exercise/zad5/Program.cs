using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Func<string, List<int>, List<int>> thething = (s, l) =>
            {
                if (s == "add")
                    l = l.Select(x => x = x + 1).ToList();
                else if (s == "multiply")
                    l = l.Select(x => x = x * 2).ToList();
                else if (s == "subtract")
                    l = l.Select(x => x = x - 1).ToList();
                return l;
            };
            while (true)
            {
                string s = Console.ReadLine();
                switch (s)
                {
                    case "end":
                        return;
                    case "print":
                        Console.WriteLine(String.Join(" ", nums));
                        break;
                    default:
                        nums = thething(s, nums);
                        break;
                }
            }
        }
    }
}
