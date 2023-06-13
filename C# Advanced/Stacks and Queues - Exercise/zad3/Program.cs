using System;
using System.Collections.Generic;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                switch (s[0])
                {
                    case "1":
                        stack.Push(int.Parse(s[1]));
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        if (stack.Any())
                            Console.WriteLine(stack.Max());
                        break;
                    case "4":
                        if (stack.Any())
                            Console.WriteLine(stack.Min());
                        break;
                }
            }
            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
