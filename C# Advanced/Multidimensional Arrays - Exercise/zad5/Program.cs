using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string s = Console.ReadLine();
            char[,] c = new char[nums[0], nums[1]];
            Queue<char> queue = new Queue<char>();
            for (int i = 0; i < s.Length; i++)
            {
                queue.Enqueue(s[i]);
            }
            for (int i = 0; i < nums[0]; i++)
            {
                if (i%2==0)
                {
                    for (int j = 0; j < nums[1]; j++)
                    {
                        c[i, j] = queue.Peek(); queue.Enqueue(queue.Dequeue());
                    }
                }
                else
                {
                    for (int j = nums[1] - 1; j >= 0; j--)
                    {
                        c[i, j] = queue.Peek(); queue.Enqueue(queue.Dequeue());
                    }
                }
            }
            for (int i = 0; i < nums[0]; i++)
            {
                for (int j = 0; j < nums[1]; j++)
                {
                    Console.Write(c[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
