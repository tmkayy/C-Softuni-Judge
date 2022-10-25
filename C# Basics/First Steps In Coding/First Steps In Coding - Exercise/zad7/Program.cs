using System;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenmenu = double.Parse(Console.ReadLine());
            double fishmenu = double.Parse(Console.ReadLine());
            double vegmenu = double.Parse(Console.ReadLine());
            Console.WriteLine((chickenmenu * 10.35 + fishmenu * 12.40 + vegmenu * 8.15) + (chickenmenu * 10.35 + fishmenu * 12.40 + vegmenu * 8.15) / 5 + 2.5);
        }
    }
}
