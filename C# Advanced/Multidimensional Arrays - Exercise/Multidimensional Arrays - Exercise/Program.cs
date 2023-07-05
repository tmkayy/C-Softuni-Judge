using System;
using System.Linq;

namespace Multidimensional_Arrays___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            int sum1 = 0; int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = nums[j];
                    if (i==j)
                    {
                        sum1 += mat[i, j];
                    }
                    if (j+1==n-i)
                    {
                        sum2 += mat[i, j];
                    }
                }
            }
            Console.WriteLine(Math.Abs(sum1-sum2));
        }
    }
}
