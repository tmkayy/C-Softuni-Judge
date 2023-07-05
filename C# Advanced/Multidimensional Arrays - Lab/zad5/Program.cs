using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] mat = new int[s[0], s[1]];
            for (int i = 0; i < s[0]; i++)
            {
                int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < s[1]; j++)
                {
                    mat[i, j] = n[j];
                }
            }
            List<int> list = new List<int>();
            List<int> STIGASEEBAVATESMENE = new List<int>();
            for (int i = 0; i < s[0]-1; i++)
            {
                for (int l = 0; l < s[1]-1; l++)
                {
                    int sum = 0;
                    for (int j = i; j < i + 2; j++)
                    {
                        for (int h = l; h < l + 2; h++)
                        {
                            sum += mat[j, h];
                            list.Add(mat[j, h]);
                        }
                    }
                    STIGASEEBAVATESMENE.Add(sum);
                }
            }
            int y = STIGASEEBAVATESMENE.IndexOf(STIGASEEBAVATESMENE.Max());
            Console.WriteLine($"{list[y * 4]} {list[y * 4 + 1]}");
            Console.WriteLine($"{list[y * 4 + 2]} {list[y * 4 + 3]}");
            Console.WriteLine(STIGASEEBAVATESMENE.Max());
        }
    }
}
