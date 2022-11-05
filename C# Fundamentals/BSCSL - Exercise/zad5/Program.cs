using System;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = "";
            string x;
            int br = 0;
            for (int i = user.Length - 1; i >= 0; i--)
            {
                password += user[i];
            }
            while (true)
            {
                x = Console.ReadLine();
                br++;
                if (x==password)
                {
                    Console.WriteLine($"User {user} logged in.");
                    return;
                }
                else if (br==4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            Console.WriteLine($"User {user} blocked!");
        }
    }
}
