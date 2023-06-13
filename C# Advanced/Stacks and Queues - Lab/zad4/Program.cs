using System;
using System.Collections.Generic;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]=='(')
                {
                    stack.Push(i);
                }
                if (s[i]==')')
                {
                    Console.WriteLine(s.Substring(stack.Peek(), i-stack.Pop()+1));
                }
            }
        }
    }
}
