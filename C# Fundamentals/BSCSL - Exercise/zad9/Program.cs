using System;

namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double saberprice = double.Parse(Console.ReadLine());
            double robeprice = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());
            double extrasaber = Math.Ceiling(students * 0.1);
            double total = students * saberprice + extrasaber*saberprice + students*robeprice;
            for (int i = 1; i <= students; i++)
            {
                if (i%6!=0)
                {
                    total += belts;
                }
            }
            if (cash>=total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {total-cash:f2}lv more.");
            }
        }
    }
}
