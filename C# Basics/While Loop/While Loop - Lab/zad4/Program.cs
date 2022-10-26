using System;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 1;
            while (m <= n)
            {
                Console.WriteLine(m);
                m = m * 2 + 1;
            }
        }
    }
}
