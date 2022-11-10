using System;
using System.Linq;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] longest = new int[0];
            int br1 = 0;
            int br2 = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                br1 = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        br1++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (br1>br2)
                {
                    br2 = br1;
                    longest = new int[br2];
                    for (int k = 0; k < br2; k++)
                    {
                        longest[k] = numbers[i];
                    }
                }
            }
            Console.WriteLine(String.Join(' ', longest));
        }
    }
}
