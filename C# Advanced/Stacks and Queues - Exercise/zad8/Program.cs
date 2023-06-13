using System;
using System.Collections.Generic;
using System.Linq;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().Trim();
            Stack<char> stack = new Stack<char>();
            char[] c = { '[', '(', '{' };
            for (int i = 0; i < s.Length; i++)
            {
                if (c.Contains(s[i]))
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (!stack.Any())
                    { Console.WriteLine("NO"); return; }
                    switch (stack.Peek())
                    {
                        case '(':
                            if (s[i] == ')')
                                stack.Pop();
                            else
                            { Console.WriteLine("NO"); return; }
                            break;
                        case '{':
                            if (s[i] == '}')
                                stack.Pop();
                            else
                            { Console.WriteLine("NO"); return; }
                            break;
                        case '[':
                            if (s[i] == ']')
                                stack.Pop();
                            else
                            { Console.WriteLine("NO"); return; }
                            break;
                    }
                }
            }
            if (stack.Any())
            {
                Console.WriteLine("NO"); return;
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
