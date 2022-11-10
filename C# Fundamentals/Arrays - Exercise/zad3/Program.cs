using System;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] zig = new int[n];
            int[] zag = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i % 2 == 1)
                {
                    zig[i] = arr[0];
                    zag[i] = arr[1];
                }
                else
                {
                    zag[i] = arr[0];
                    zig[i] = arr[1];
                }
            }
            Console.WriteLine(String.Join(" ", zag));
            Console.WriteLine(String.Join(" ", zig));
        }
    }
}
