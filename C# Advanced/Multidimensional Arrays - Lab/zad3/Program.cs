using System;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int[] z = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = z[j];
                    if (i ==j)
                    {
                        sum += mat[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
