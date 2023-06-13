using System;
using System.Collections.Generic;
using System.Linq;

namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string st = string.Empty;
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "1")
                {
                    st += s[1];
                    stack.Push(st);
                }
                else if (s[0] == "2")
                {
                    int count = int.Parse(s[1]);
                    st = st.Remove(st.Length - count, count); // common hari L
                    stack.Push(st);
                }
                else if (s[0] == "3")
                {
                    Console.WriteLine(st.ElementAt(int.Parse(s[1]) - 1));
                }
                else if (s[0] == "4")
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                        if (stack.Any())
                        {
                            st = stack.Peek();
                        }
                        else
                        {
                            st = string.Empty;
                        }
                    }
                }
            }
        }
    }
}
