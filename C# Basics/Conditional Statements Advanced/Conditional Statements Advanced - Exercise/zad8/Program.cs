using System;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h1 = double.Parse(Console.ReadLine());
            double m1 = double.Parse(Console.ReadLine());
            double h2 = double.Parse(Console.ReadLine());
            double m2 = double.Parse(Console.ReadLine());
            double time1 = h1 * 60 + m1;
            double time2 = h2 * 60 + m2;
            if (time2>time1)
            {
                Console.WriteLine("Late");
                if ((time2-time1)<60)
                {
                    Console.WriteLine($"{time2-time1} minutes after the start");
                }
                else if ((time2 - time1) >= 60)
                {
                    if ((time2 - time1)%60<10)
                    {
                        Console.WriteLine($"{Math.Truncate((time2 - time1) / 60)}:0{(time2 - time1) % 60} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Truncate((time2 - time1) / 60)}:{(time2 - time1) % 60} hours after the start");
                    }
                }
            }
            else if (time1==time2||time1-time2<=30||time1-time2!<0)
            {
                Console.WriteLine("On time");
                if (time1 != time2)
                {
                    Console.WriteLine($"{time1 - time2} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                if ((time1 - time2) < 60)
                {
                    Console.WriteLine($"{time1 - time2} minutes before the start");
                }
                else if ((time1 - time2) >= 60)
                {
                    if ((time1 - time2) % 60 < 10)
                    {
                        Console.WriteLine($"{Math.Truncate((time1 - time2) / 60)}:0{(time1 - time2) % 60} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Truncate((time1 - time2) / 60)}:{(time1 - time2) % 60} hours before the start");
                    }
                }
            }
        }
    }
}
