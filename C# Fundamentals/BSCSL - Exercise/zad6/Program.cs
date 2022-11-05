using System;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int originaln = n;
            int sum = 0;
            int factorial = 1;
            while (true)
            {
                int digit = n % 10;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
                factorial = 1;
                n /= 10;
                if (n == 0)
                {
                    break;
                }
            }
            if (sum == originaln)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
