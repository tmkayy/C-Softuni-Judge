using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Console.WriteLine(String.Join(", ", queue.Where(x=>x%2==0)));
        }
    }
}
