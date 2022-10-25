using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            double depozirana = double.Parse(Console.ReadLine());
            double months = double.Parse(Console.ReadLine());
            double lihvenprocent = double.Parse(Console.ReadLine());
            Console.WriteLine($"{depozirana + months * ((depozirana * lihvenprocent/100) / 12)}");
        }
    }
}
