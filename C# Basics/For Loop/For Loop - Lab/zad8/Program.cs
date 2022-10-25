using System;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (min > x)
                {
                    min = x; ;
                }
                if (max < x)
                {
                    max = x;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}