using System;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            switch (day)
            {
                case "Sunday":
                    Console.WriteLine("closed");
                    break;
                default:
                    if (n>=10&&n<=18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
            }
        }
    }
}
