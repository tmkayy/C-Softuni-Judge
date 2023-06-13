using System;
using System.Collections.Generic;
using System.Linq;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] s = Console.ReadLine().Split(' ');
            Queue<int> stack = new Queue<int>();
            for (int i = 0; i < nsx[0]; i++)
            {
                stack.Enqueue(int.Parse(s[i]));
            }
            for (int i = 0; i < nsx[1]; i++)
            {
                stack.Dequeue();
            }
            if (!stack.Any())
            {
                Console.WriteLine(0); return;
            }
            int min = int.MaxValue;
            while (stack.Any())
            {
                int x = stack.Dequeue();
                if (x == nsx[2])
                {
                    Console.WriteLine("true"); return;
                }
                else
                {
                    if (x < min)
                    {
                        min = x;
                    }
                }
            }
            Console.WriteLine(min);
        }
    }
}
