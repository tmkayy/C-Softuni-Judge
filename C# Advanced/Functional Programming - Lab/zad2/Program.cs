using System;
using System.Linq;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> count = (a) => Console.WriteLine(a.Length);
            Action<int[]> sum = (a) => Console.WriteLine(a.Sum());
            int[] a = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            count(a);
            sum(a);
        }
    }
}
