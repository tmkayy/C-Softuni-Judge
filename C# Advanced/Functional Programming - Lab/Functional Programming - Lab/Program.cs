using System;
using System.Linq;

namespace Functional_Programming___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> even = (a) => a % 2 == 0;
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).Where(even).ToArray();
            Array.Sort(arr);
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
