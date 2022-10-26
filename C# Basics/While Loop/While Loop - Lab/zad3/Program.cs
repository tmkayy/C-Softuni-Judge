using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum < n)
            {
                int x = int.Parse(Console.ReadLine());
                sum = sum + x;
            }
            Console.WriteLine(sum);
        }
    }
}
