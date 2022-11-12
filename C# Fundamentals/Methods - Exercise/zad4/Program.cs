using System;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password=Console.ReadLine();
            Validation(password);
        }
        static void Validation(string password)
        {
            int br = 0;
            bool valid = false;
            if (password.Length>=6&&password.Length<=10)
            {
                valid = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetterOrDigit(password[i]))
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    br++;
                }
            }
            if (br<2)
            {
                valid=false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (valid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
