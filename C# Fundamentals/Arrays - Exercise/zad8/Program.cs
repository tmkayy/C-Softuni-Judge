using System;
using System.Linq;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int magic = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length-1; j++)
                {
                    if (numbers[i] + numbers[j+1]==magic)
                    {
                        Console.Write(numbers[i]+ " " + numbers[j+1]);
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
    }
}
