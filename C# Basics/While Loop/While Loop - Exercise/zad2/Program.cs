using System;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string zadname = " ";
            double ocenka;
            double sum = 0;
            int br = 0;
            int fail = 0;
            string lastzad=" ";
            while (true)
            {
                zadname = Console.ReadLine();
                if (zadname=="Enough")
                {
                    break;
                }
                ocenka = double.Parse(Console.ReadLine());
                if (ocenka <=4)
                {
                    fail++;
                    if (fail==n)
                    {
                        Console.WriteLine($"You need a break, {n} poor grades.");
                        return;
                    }
                }
                sum = sum + ocenka;
                br++;
                lastzad = zadname;
            }
            Console.WriteLine($"Average score: {sum/br:f2}");
            Console.WriteLine($"Number of problems: {br}");
            Console.WriteLine($"Last problem: {lastzad}");
        }
    }
}
