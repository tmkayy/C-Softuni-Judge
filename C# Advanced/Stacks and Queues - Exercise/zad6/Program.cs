using System;
using System.Collections.Generic;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", "));
            while(true)
            {
                string[] s = Console.ReadLine().Split(" ");
                switch(s[0])
                {
                    case "Play":
                        queue.Dequeue();
                        if(queue.Count == 0)
                        {
                            Console.WriteLine("No more songs!");
                            return;
                        }
                        break;
                    case "Add":
                        if (!queue.Contains(String.Join(" ", s.Skip(1))))
                        {
                            queue.Enqueue(String.Join(" ", s.Skip(1)));
                        }
                        else
                        {
                            Console.WriteLine($"{String.Join(" ", s.Skip(1))} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(String.Join(", ", queue));
                        break;
                }
            }
        }
    }
}
