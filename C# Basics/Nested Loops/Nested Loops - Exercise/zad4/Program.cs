using System;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string pres = Console.ReadLine();
            double x;
            double sum = 0;
            double avgsum = 0;
            int br = 0;
            while (pres!="Finish")
            {
                sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    x = double.Parse(Console.ReadLine());
                    sum += x;
                }
                br++;
                Console.WriteLine($"{pres} - {sum/n:f2}.");
                avgsum += sum / n;
                pres = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {avgsum/br:f2}.");
        }
    }
}
