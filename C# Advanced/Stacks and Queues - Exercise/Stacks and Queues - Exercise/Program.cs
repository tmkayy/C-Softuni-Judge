using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] s = Console.ReadLine().Split(' ');
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < nsx[0]; i++)
            {
                stack.Push(int.Parse(s[i]));
            }
            for (int i = 0;i< nsx[1]; i++)
            {
                stack.Pop();
            }
            if (!stack.Any())
            {
                Console.WriteLine(0); return;
            }
            int min = int.MaxValue;
            while (stack.Any())
            {
                int x = stack.Pop();
                if (x == nsx[2])
                {
                    Console.WriteLine("true"); return;
                }
                else
                {
                    if (x<min)
                    {
                        min = x;
                    }
                }
            }
            Console.WriteLine(min);
        }
    }
}
