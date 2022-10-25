using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo1 = double.Parse(Console.ReadLine());
            if (chislo1%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
