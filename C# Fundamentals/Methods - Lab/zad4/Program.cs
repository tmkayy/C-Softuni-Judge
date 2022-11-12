using System;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Triangle(n);
        }
        static void Triangle (int n)
        {
            for (int row = 1; row <= n; row++)
            {
                NestedCycle(row);
            }
            for (int row = n-1; row >= 1; row--)
            {
                NestedCycle(row);
            }
        }
        static void NestedCycle(int row)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write(column + " ");
            }
            Console.WriteLine();
        }
    }
}
