using System;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double fail = 0;
            double br = 0;
            double sum = 0;
            while (br < 12)
            {
                double ocenka = double.Parse(Console.ReadLine());
                sum = sum + ocenka;
                if (ocenka < 4)
                {
                    fail++;
                    if (fail == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {br} grade");
                        return;
                    }
                }
                br++;
            }
            double average = sum / br;
            if (br == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}