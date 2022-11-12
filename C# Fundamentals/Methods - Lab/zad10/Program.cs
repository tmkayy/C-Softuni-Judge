using System;

namespace zad10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(EvenSum(n)*OddSum(n));
        }
        static int EvenSum(int n)
        {
            int sumeven = 0;
            while (n!=0)
            {
                int digit = Math.Abs(n%10);
                if (digit%2==0)
                {
                    sumeven+=digit;
                }
                n = n / 10;
            }
            return sumeven;
        }
        static int OddSum(int n)
        {
            int sumodd = 0;
            while (n != 0)
            {
                int digit = Math.Abs(n % 10);
                if (digit % 2 == 1)
                {
                    sumodd += digit;
                }
                n = n / 10;
            }
            return sumodd;
        }
    }
}
