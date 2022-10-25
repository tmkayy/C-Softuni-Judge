using System;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            double count = double.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                string rater = Console.ReadLine();
                double rate = double.Parse(Console.ReadLine());
                points = points + (rater.Length * rate) / 2;
                if (points>1250.5)
                {
                    break;
                }
            }
            if (points>1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5-points:f1} more!");
            }
        }
    }
}
