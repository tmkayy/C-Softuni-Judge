using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            Regex regex = new Regex(@"\+359([ \-])2\1\d{3}\1\d{4}\b");
            MatchCollection matches = regex.Matches(nums);
            Console.WriteLine(String.Join(", ", matches));
        }
    }
}
