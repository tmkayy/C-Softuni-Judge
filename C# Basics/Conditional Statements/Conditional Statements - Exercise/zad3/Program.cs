using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hr = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int min2 = min + 15;
            if (min2==60)
            {
                hr = hr + 1;
                if (hr>23)
                {
                    hr = 0;
                }
                Console.WriteLine($"{hr}:00");
            }
            else if (min2>60&&min2%60<10)
            {
                hr = hr + 1;
                if (hr>23)
                {
                    hr = 0;
                }
                Console.WriteLine($"{hr}:0{min2-60}");
            }
            else if (min2 > 60 && min2 % 60 >= 10)
            {
                hr = hr + 1;
                if (hr > 23)
                {
                    hr = 0;
                }
                Console.WriteLine($"{hr}:{min2-60}");
            }
            else
            {
                Console.WriteLine($"{hr}:{min2}");
            }
        }
    }
}
