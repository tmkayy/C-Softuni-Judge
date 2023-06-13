using System;
using System.Collections.Generic;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]s = Console.ReadLine().Split(' ');
            s = s.Reverse().ToArray();
            Stack<string> stack = new Stack<string>();
            for(int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);
            }
            int result = 0;
            string znak = string.Empty;
            while (stack.Any())
            {
                if (int.TryParse(stack.Peek(), out int n))
                {
                    if(znak!= string.Empty)
                    {
                        if(znak == "+")
                        {
                            result += n;
                        }
                        else
                        {
                            result -= n;
                        }
                        znak = string.Empty;
                        stack.Pop();
                    }
                    else
                    {
                        result = n;
                        stack.Pop();
                    }
                }
                else
                {
                    znak = stack.Pop();
                }
            }
            Console.WriteLine(result);
        }
    }
}
