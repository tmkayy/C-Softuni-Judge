using System;
using System.Linq;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] mat = new int[s[0], s[1]];
            for (int i = 0; i < s[1]; i++)
            {
                int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < s[0]; j++)
                {
                    mat[i, j] = n[j];
                }
            }
            for (int i = 0; i < s[0]; i++)
            {
                int sum = 0;
                for (int j = 0; j < s[1]; j++)
                {
                    sum += mat[j, i];
                }
                Console.WriteLine(sum); sum = 0;
            }
        }
    }
}
