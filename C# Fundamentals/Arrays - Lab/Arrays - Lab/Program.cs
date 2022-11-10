using System;

namespace Arrays___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] day = new string[1];
            day[0] = Console.ReadLine();
            switch (day[0])
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }
    }
}
