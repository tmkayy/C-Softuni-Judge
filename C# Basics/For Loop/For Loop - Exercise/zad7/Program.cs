using System;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double musala = 0;
            double monblan = 0;
            double kilimanjaro = 0;
            double k2 = 0;
            double everest = 0;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                if (x<=5)
                {
                    musala = musala +x;
                    sum = sum + x;
                }
                else if (x>=6&&x<=12)
                {
                    monblan = monblan+x;
                    sum = sum + x;
                }
                else if (x >= 13 && x <= 25)
                {
                    kilimanjaro= kilimanjaro+x;
                    sum = sum + x;
                }
                else if (x >= 26 && x <= 40)
                {
                    k2=k2+x;
                    sum = sum + x;
                }
                else
                {
                    everest= everest +x;
                    sum = sum + x;
                }
            }
            Console.WriteLine($"{(musala * 100) / sum:f2}%");
            Console.WriteLine($"{(monblan * 100) / sum:f2}%");
            Console.WriteLine($"{(kilimanjaro * 100) / sum:f2}%");
            Console.WriteLine($"{(k2 * 100) / sum:f2}%");
            Console.WriteLine($"{(everest * 100) / sum:f2}%");
        }
    }
}
