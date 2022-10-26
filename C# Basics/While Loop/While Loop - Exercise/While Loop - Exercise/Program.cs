using System;

namespace While_Loop___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book1 = Console.ReadLine();
            string book2 = Console.ReadLine();
            int br = 0;
            while (book2!= "No More Books")
            {
                if (book2==book1)
                {
                    break;
                }
                book2 = Console.ReadLine();
                br++;
            }
            if (book2==book1)
            {
                Console.WriteLine($"You checked {br} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {br} books.");
            }
        }
    }
}
