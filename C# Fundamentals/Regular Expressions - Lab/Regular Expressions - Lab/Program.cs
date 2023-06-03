using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            MatchCollection matches = regex.Matches(name);
            foreach (Match match in matches)
            {
                Console.Write(match.Value+" ");
            }
        }
    }
}
