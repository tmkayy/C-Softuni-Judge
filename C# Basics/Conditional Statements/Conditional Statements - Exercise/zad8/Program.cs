using System;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            double epduration = double.Parse(Console.ReadLine());
            double breakduration = double.Parse(Console.ReadLine());
            double lunch = breakduration / 8;
            double otdih = breakduration / 4;
            double total = epduration + lunch + otdih;
            if (total<=breakduration)
            {
                Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(breakduration-total)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movie}, you need {Math.Ceiling(total-breakduration)} more minutes.");
            }
        }
    }
}
