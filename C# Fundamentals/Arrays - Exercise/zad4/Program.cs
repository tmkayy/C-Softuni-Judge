using System;
using System.Linq;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    int x = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = x;
                }
            }
            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
