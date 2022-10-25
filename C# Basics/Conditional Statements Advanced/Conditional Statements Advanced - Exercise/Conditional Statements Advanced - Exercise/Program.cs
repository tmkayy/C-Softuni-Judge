using System;

namespace Conditional_Statements_Advanced___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double red = double.Parse(Console.ReadLine());
            double kolona = double.Parse(Console.ReadLine());
            if (name == "Premiere")
            {
                double income = red * kolona * 12;
                Console.WriteLine($"{income:f2} leva");
            }
            else if (name == "Normal")
            {
                double income = red * kolona * 7.5;
                Console.WriteLine($"{income:f2} leva");
            }
            else
            {
                double income = red * kolona * 5;
                Console.WriteLine($"{income:f2} leva");
            }
        }
    }
}
