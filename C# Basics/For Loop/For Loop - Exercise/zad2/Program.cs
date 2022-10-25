using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (max < x)
                {
                    max = x;
                }
                sum = sum + x;
            }
            int sum2 = sum - max;
            if (max == sum2)
            {
                Console.WriteLine($"Yes\nSum = {max}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(sum2 - max)}");
            }
        }
    }
}
