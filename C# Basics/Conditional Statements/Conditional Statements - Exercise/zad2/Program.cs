using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo = double.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (chislo<=100)
            {
                bonus = 5;
            }
            else if (chislo>100&&chislo<=1000)
            {
                bonus = chislo / 5;
            }
            else
            {
                bonus = chislo / 10;
            }
            if (chislo%2==0)
            {
                bonus = bonus + 1;
            }
            else if (chislo%10==5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(chislo+bonus);
        }

    }
}
