using System;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                sum = sum + x;
            }
            Console.WriteLine(sum);
        }
    }
}
