using System;

namespace zad10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    sum1 = sum1 + x;
                }
                else if (i%2==1)
                {
                    sum2 = sum2 + x;
                }
            }
            if (sum1==sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum1-sum2)}");
            }
        }
    }
}
