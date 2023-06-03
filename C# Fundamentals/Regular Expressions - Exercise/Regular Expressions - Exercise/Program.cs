using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regular_Expressions___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@">>(?<prod>[A-Z][a-z]*|[A-Z]+)<<(?<price>\d+|\d+\.\d+)!(?<quan>\d+)");
            List<string> prods = new List<string>();
            double cash4brokeniggas = 0;
            while (true)
            {
                string buyshit = Console.ReadLine();
                if (regex.IsMatch(buyshit))
                {
                    Match match = regex.Match(buyshit);
                    prods.Add(match.Groups["prod"].Value.ToString());
                    cash4brokeniggas += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quan"].Value);
                }
                if(buyshit =="Purchase")
                {  break;}
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in prods)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {cash4brokeniggas:f2}");
        }
    }
}
