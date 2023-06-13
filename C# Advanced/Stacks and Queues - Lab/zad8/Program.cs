using System;
using System.Collections.Generic;
using System.Linq;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "end")
                {
                    Console.WriteLine($"{br} cars passed the crossroads.");
                    return;
                }
                else if (s == "green")
                {
                    for (int i = 0; i < n && queue.Any(); i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        br++;
                    }
                }
                else
                {
                    queue.Enqueue(s);
                }
            }
        }
    }
}
