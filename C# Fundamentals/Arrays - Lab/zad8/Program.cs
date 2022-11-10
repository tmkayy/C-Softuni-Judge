using System;
using System.Linq;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length-1];
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }
            while (true)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers.Length-1==i)
                    {
                        break;
                    }
                    condensed[i] = numbers[i] + numbers[i + 1];
                }
                if (condensed.Length == 1)
                {
                    break;
                }
                numbers = condensed;
                condensed = new int[numbers.Length - 1];
            }
            Console.WriteLine(condensed.Sum());
        }
    }
}
