using System;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToArray();
            if (n.Length >= 3)
            {
                Console.WriteLine(n[0] + " " + n[1] + " " + n[2]);
            }
            else
            {
                foreach (var item in n)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
