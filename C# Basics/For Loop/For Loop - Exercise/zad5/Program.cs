using System;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tabs = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double penalty = 0;
            for (int i = 1; i <= tabs; i++)
            {
                string x = Console.ReadLine();
                if (x == "Facebook")
                {
                    penalty = penalty + 150;
                }
                else if (x == "Instagram")
                {
                    penalty = penalty + 100;
                }
                else if (x == "Reddit")
                {
                    penalty = penalty + 50;
                }
            }
            if (penalty >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary - penalty);
            }
        }
    }
}
