using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb[0])
                {
                    for (int j = 1; j <= bomb[1]; j++)
                    {
                        if (i!=0)
                        {
                            numbers.RemoveAt(i - 1);
                            i--;
                        }
                    }
                    for (int y = 1; y <= bomb[1]; y++)
                    {
                        if (i<numbers.Count-1)
                        {
                            numbers.RemoveAt(i + 1);
                        }
                    }
                    numbers.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
