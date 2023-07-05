using System;
using System.Linq;

namespace Multidimensional_Arrays___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] mat = new int[s[0], s[1]]; int sum = 0;
            for (int i = 0; i < s[0]; i++)
            {
                int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < s[1]; j++)
                {
                    mat[i, j] = n[j];
                    sum += mat[i, j];
                }
            }
            Console.WriteLine(s[0] + "\n" + s[1] + "\n" + sum);
        }
    }
}
