using System;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double standard = 0;
            double student = 0;
            double kid = 0;
            double total = 0;
            double used;
            while (name!="Finish")
            {
                double seats = double.Parse(Console.ReadLine());
                used = 0;
                string ticket;
                for (int i = 1; i <= seats; i++)
                {
                    ticket=Console.ReadLine();
                    if (ticket == "End")
                    {
                        break;
                    }
                    used++;
                    switch (ticket)
                    {
                        case "student":
                            student++;
                            break;
                        case "standard":
                            standard++;
                            break;
                        case "kid":
                            kid++;
                            break;
                    }
                }
                Console.WriteLine($"{name} - {used * 100 / seats:f2}% full.");
                name = Console.ReadLine();
            }
            total += kid + student + standard;
            Console.WriteLine($"Total tickets: {total}");
            Console.WriteLine($"{student * 100 / total:f2}% student tickets.");
            Console.WriteLine($"{standard * 100 / total:f2}% standard tickets.");
            Console.WriteLine($"{kid * 100 / total:f2}% kids tickets.");
        }
    }
}
