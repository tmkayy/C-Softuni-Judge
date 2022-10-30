using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int br = 0;
            for (int x = 0; x <= n; x++)
            {
                for (int y = 0; y <= n; y++)
                {
                    for (int z = 0; z <= n; z++)
                    {
                        if (x+y+z==n)
                        {
                            br++;
                        }
                    }
                }
            }
            Console.WriteLine(br);
        }
    }
}
