using System;
using System.Text.RegularExpressions;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"%(?<cust>[A-Z][a-z]+)%.*?<(?<prod>\w+)>.*?\|(?<quan>\d+)\|.*?(?<value>\d+|\d+\.\d+)\$");
            double sum = 0;
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "end of shift")
                {
                    Console.WriteLine($"Total income: {sum:f2}");
                    break;
                }
                Match match = regex.Match(s);
                if (match.Success)
                {
                    Console.WriteLine($"{match.Groups["cust"]}: {match.Groups["prod"]} - {double.Parse(match.Groups["quan"].ToString())* double.Parse(match.Groups["value"].ToString()):f2}");
                    sum += double.Parse(match.Groups["quan"].ToString()) * double.Parse(match.Groups["value"].ToString());
                }
            }
        }
    }
}
