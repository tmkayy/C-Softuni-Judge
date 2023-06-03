using System;
using System.Text.RegularExpressions;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //COMMON HRIS L
            Regex regex = new Regex(@"(^|(?<=\s))([A-Za-z]|\d)[A-Za-z.\-_0-9]*?[A-Za-z]@[a-z][a-z-]*?[a-z]\.([a-z]([\.\-]?[a-z]+)+)(\b|(?=\s))");
            string s = Console.ReadLine();
            MatchCollection matches = regex.Matches(s);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
