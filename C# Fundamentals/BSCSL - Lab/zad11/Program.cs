using System;

namespace zad10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b > 10)
            {
                Console.WriteLine($"{n} X {b} = {n * b}");
                return;
            }
            for (int i = b; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}
