using System;

namespace gradusi
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradusi = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (gradusi >= 10 && gradusi <= 18)
            {
                if (name == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (name == "Afternoon" || name == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (gradusi > 18 && gradusi <= 24)
            {
                if (name == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (name == "Morning" || name == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (gradusi >= 25)
            {
                if (name == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (name == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (name == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {gradusi} degrees, get your {outfit} and {shoes}.");
        }
    }
}
