using System;
using System.Collections.Generic;
using System.Linq;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            while (true)
            {
                string[] s = Console.ReadLine().Split(" ");
                s[0] = s[0].ToLower();
                switch (s[0])
                {
                    case "end":
                        Console.WriteLine("Sum: " + stack.Sum());
                        return;
                    case "add":
                        stack.Push(int.Parse(s[1]));
                        stack.Push(int.Parse(s[2]));
                        break;
                    case "remove":
                        if (int.Parse(s[1])<=stack.Count)
                        {
                            for (int i = 0; i < int.Parse(s[1]); i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;

                }
            }
        }
    }
}
