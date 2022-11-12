using System;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NxN(n);
        }
        static void NxN(int n)
        {
            for (int column = 1; column <= n; column++)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
