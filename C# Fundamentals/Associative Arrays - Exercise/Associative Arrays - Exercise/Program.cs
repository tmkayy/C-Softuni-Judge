using System;
using System.Collections.Generic;

namespace Associative_Arrays___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Dictionary<char, int> count = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsWhiteSpace(s[i]))
                {
                    if (count.ContainsKey(s[i]))
                    {
                        count[s[i]]++;
                    }
                    else
                    {
                        count.Add(s[i], 1);
                    }
                }
            }
            foreach (KeyValuePair<char, int> entry in count)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
