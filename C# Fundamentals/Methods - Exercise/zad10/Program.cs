using System;

namespace zad10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (Divisable(i)&&Odd(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool Divisable (int i)
        {
            bool top = false;
            int sum=0;
            while (i!=0)
            {
                int x = i % 10;
                sum += x;
                i = i / 10;
            }
            if (sum%8==0)
            {
                top = true;
            }
            return top;
        }
        static bool Odd(int i)
        {
            bool odd = false;
            while (i != 0)
            {
                int x = i % 10;
                if (x%2==1)
                {
                    odd = true;
                    break;
                }
                i = i / 10;
            }
            return odd;
        }

    }
}
