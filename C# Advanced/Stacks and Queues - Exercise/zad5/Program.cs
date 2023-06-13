using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int> (Console.ReadLine().Split(' ').Select(int.Parse));
            int capacity  = int.Parse(Console.ReadLine());
            int sum = 0;
            int br = 1;
            while (clothes.Any())
            {
                if (sum+clothes.Peek()<=capacity)
                {
                    sum += clothes.Pop();
                    if (sum==capacity&&clothes.Any())
                    {
                        br++;
                        sum = 0;
                    }
                }
                else
                {
                    br++;
                    sum = 0;
                    sum += clothes.Pop();
                }
            }
            Console.WriteLine(br);
        }
    }
}
