using System;
using System.Linq;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n==1)
            {
                Console.WriteLine(1); return;
            }
            long[][] pas = new long[n][];
            long[] r0 = { 1 }; long[] r1 = { 1, 1};
            pas[0] = r0;
            pas[1] = r1;
            for (int i = 2; i < n; i++)
            {
                long[]z = new long[i+1];
                z[0] = pas[i - 1][0];
                z[i] = pas[i - 1][i-1];
                for (int j = 1; j < i; j++)
                {
                    z[j] = pas[i - 1][j-1] + pas[i - 1][j];
                }
                pas[i] = z;
            }
            Console.WriteLine(string.Join(Environment.NewLine, pas.Select(x => string.Join(' ', x))));
        }
    }
}
