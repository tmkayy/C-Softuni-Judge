using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] n = new int[nums[0], nums[1]];
            for (int i = 0; i < nums[0]; i++)
            {
                int[] lols = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < nums[1]; j++)
                {
                    n[i, j] = lols[j];
                }
            }
            List<int> FML1 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            List<int> FML2 = new List<int>();
            int max = int.MinValue;
            for (int i = 0; i < nums[0] - 2; i++)
            {
                for (int j = 0; j < nums[1] - 2; j++)
                {
                    int sum = 0;
                    for (int h = i; h < i + 3; h++)
                    {
                        for (int l = j; l < j + 3; l++)
                        {
                            FML2.Add(n[h, l]);
                            sum += n[h, l];
                        }
                    }
                    if (sum > max)
                    {
                        for (int y = 0; y < FML2.Count; y++)
                        {
                            FML1[y] = FML2[y];
                        }
                        max = sum;
                        FML2.Clear();
                    }
                    else
                    {
                        FML2.Clear();
                    }
                }
            }
            Console.WriteLine($"Sum = {max}");
            Console.WriteLine(FML1[0] + " " + FML1[1] + " " + FML1[2]);
            Console.WriteLine(FML1[3] + " " + FML1[4] + " " + FML1[5]);
            Console.WriteLine(FML1[6] + " " + FML1[7] + " " + FML1[8]);
        }
    }
}
