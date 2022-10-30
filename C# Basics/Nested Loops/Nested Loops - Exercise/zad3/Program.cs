using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int sumprosti = 0;
            int sumneprosti = 0;
            int x;
            while (n!="stop")
            {
                x = int.Parse(n);
                if (x<0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool prosto = true;
                    for (int i = 2; i <= Math.Sqrt(x); i++)
                    {
                        if (x % i == 0)
                        {
                            prosto = false;
                        }
                    }
                    if (prosto)
                    {
                        sumprosti += x;
                    }
                    else
                    {
                        sumneprosti += x;
                    }
                }
                n = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumprosti}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumneprosti}");
        }
    }
}
