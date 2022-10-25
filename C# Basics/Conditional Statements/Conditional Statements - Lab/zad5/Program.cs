using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            if (chislo<100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (chislo>=100&&chislo<=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (chislo>200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
