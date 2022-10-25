using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo1 = double.Parse(Console.ReadLine());
            double chislo2 = double.Parse(Console.ReadLine());
            if (chislo1>chislo2)
            {
                Console.WriteLine(chislo1);
            }
            else
            {
                Console.WriteLine(chislo2);
            }
        }
    }
}
