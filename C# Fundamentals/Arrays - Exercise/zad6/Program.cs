using System;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumleft;
            int sumright;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumleft = 0;
                sumright = 0;
                for (int j = 0; j < i; j++)
                {
                    sumleft += numbers[j];
                }
                for (int x = i; x < numbers.Length - 1; x++)
                {
                    sumright += numbers[x + 1];
                }
                if (sumleft == sumright)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
