using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededcash = double.Parse(Console.ReadLine());
            double cash = double.Parse(Console.ReadLine());
            double cash2;
            string status = " ";
            int fail = 0;
            int day = 0;
            while (true)
            {
                status = Console.ReadLine();
                cash2 = double.Parse(Console.ReadLine());
                day++;
                switch (status)
                {
                    case "spend":
                        if (cash>cash2)
                        {
                            cash = cash - cash2;
                        }
                        else
                        {
                            cash = 0;
                        }
                        fail++;
                        if (fail==5)
                        {
                            Console.WriteLine($"You can't save the money.\n{day}");
                            return;
                        }
                        break;
                    case "save":
                        cash = cash + cash2;
                        fail = 0;
                        break;
                }
                if (cash>=neededcash)
                {
                    Console.WriteLine($"You saved the money for {day} days.");
                    return;
                }
            }
        }
    }
}
