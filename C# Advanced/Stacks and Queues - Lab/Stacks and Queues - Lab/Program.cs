using System;
using System.Collections.Generic;

namespace Stacks_and_Queues___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);
            }
            Console.WriteLine(String.Join(string.Empty, stack));
        }
    }
}
