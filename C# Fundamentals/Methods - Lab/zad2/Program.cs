using System;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            Check(a);
        }
        static void Check(double a)
        {
            if (a>=5.5)
            {
                Console.WriteLine("Excellent");
            }
            else if (a<5.5&&a>=4.5)
            {
                Console.WriteLine("Very good");
            }
            else if (a < 4.5 && a >= 3.5)
            {
                Console.WriteLine("Good");
            }
            else if (a < 3.5 && a >= 3)
            {
                Console.WriteLine("Poor");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
