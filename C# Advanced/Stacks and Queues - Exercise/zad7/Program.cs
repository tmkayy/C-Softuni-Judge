using System;
using System.Collections.Generic;
using System.Linq;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            int petrol = 0;
            int countthingy = 0;
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                queue.Enqueue(int.Parse(s[0]) - int.Parse(s[1]));
            }
            List<int> idk = queue.ToList();
            while (true)
            {
                if (petrol+queue.Peek()>=0)
                {
                    petrol += queue.Peek();
                    countthingy++;
                    queue.Enqueue(queue.Dequeue());
                    if (countthingy==n-1)
                    {
                        Console.WriteLine(br);
                        return;
                    }
                }
                else
                {
                    countthingy = 0;
                    br++;
                    if (br==n)
                    {
                        return;
                    }
                    petrol = 0;
                    queue.Clear();
                    for (int i = 0; i < idk.Count; i++)
                    {
                        queue.Enqueue(idk[i]);
                    }
                    for (int i = 0; i < br; i++)
                    {
                        queue.Enqueue(queue.Dequeue());
                    }
                }
            }
        }
    }
}
