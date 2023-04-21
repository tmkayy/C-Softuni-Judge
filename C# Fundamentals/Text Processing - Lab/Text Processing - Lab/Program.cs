using System;
using System.Linq;

namespace Text_Processing___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "end")
                {
                    return;
                }
                Console.Write(s+ " = ");
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    Console.Write(s[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
