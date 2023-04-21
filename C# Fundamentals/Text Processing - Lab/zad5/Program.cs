using System;
using System.Text;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder characters = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    digits.Append(s[i]);
                }
                else if (char.IsLetter(s[i]))
                {
                    letters.Append(s[i]);
                }
                else
                {
                    characters.Append(s[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(characters);
        }
    }
}
