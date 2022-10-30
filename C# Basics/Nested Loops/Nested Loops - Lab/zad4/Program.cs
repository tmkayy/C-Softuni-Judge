using System;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int counter = 0;
            bool doesntexist = true;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;
                    if (i + j == magic)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magic})");
                        doesntexist = false;
                        return;

                    }
                }
            }
            if (doesntexist)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}
