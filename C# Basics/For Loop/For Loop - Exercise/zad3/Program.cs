using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                if (x<200)
                {
                    p1++;
                }
                else if (x>=200&&x<=399)
                {
                    p2++;
                }
                else if (x >= 400 && x <= 599)
                {
                    p3++;
                }
                else if (x >= 600 && x <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            Console.WriteLine($"{(p1 * 100) / n:f2}%");
            Console.WriteLine($"{(p2 * 100) / n:f2}%");
            Console.WriteLine($"{(p3 * 100) / n:f2}%");
            Console.WriteLine($"{(p4 * 100) / n:f2}%");
            Console.WriteLine($"{(p5 * 100) / n:f2}%");
        }
    }
}
