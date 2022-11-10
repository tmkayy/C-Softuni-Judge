using System;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumeven = 0;
            int sumodd = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumeven += numbers[i];
                }
                else
                {
                    sumodd += numbers[i];
                }
            }
            Console.WriteLine(sumeven-sumodd);
        }
    }
}
