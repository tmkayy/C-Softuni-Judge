using System;
using System.Text.RegularExpressions;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();
            Regex regex = new Regex(@"\b(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})");
            MatchCollection matches = regex.Matches(dates);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
            }
        }
    }
}
