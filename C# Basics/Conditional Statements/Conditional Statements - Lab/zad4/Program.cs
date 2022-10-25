using System;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            string dick = Console.ReadLine();
            if (dick=="s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
