using System;
using System.Linq;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool bigger;
            for (int i = 0; i < numbers.Length; i++)
            {
                bigger = true;
                for (int j = i; j < numbers.Length-1; j++)
                {
                    if (numbers[i] > numbers[j+1])
                    {
                        bigger = true;
                    }
                    else
                    {
                        bigger = false;
                        break;
                    }
                }
                if (bigger)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
