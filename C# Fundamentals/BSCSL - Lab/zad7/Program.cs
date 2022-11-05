using System;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int money;
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            switch (day)
            {
                case "Weekday":
                    if (age > 18 && age <= 64)
                    {
                        money = 18;
                    }
                    else
                    {
                        money = 12;
                    }
                    break;
                case "Weekend":
                    if (age > 18 && age <= 64)
                    {
                        money = 20;
                    }
                    else
                    {
                        money = 15;
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        money = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        money = 12;
                    }
                    else
                    {
                        money = 10;
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    return;
            }
            Console.WriteLine(money + "$");
        }
    }
}
