using System;
using System.Collections.Generic;
using System.Linq;

namespace zad10
{
    internal class Program
    {
        static Predicate<string> mmmmm(string s1, string s2)
        {
            switch (s1)
            {
                case "Starts with":
                    return x => !x.StartsWith(s2);
                case "Ends with":
                    return x => !x.EndsWith(s2);
                case "Length":
                    return x => x.Length != int.Parse(s2);
                default:
                    return x => !x.Contains(s2);
            }
        }
        static void Main(string[] args)
        {
            List<string> party = Console.ReadLine().Split(' ').ToList();
            List<string[]> predicate = new List<string[]>();
            while (true)
            {
                string[] s = Console.ReadLine().Split(';');
                if (s[0]=="Print")
                {
                    while (predicate.Any())
                    {
                        string[] s2 = predicate[0];
                        party = party.FindAll(mmmmm(s2[1], s2[2])); predicate.Remove(predicate[0]);
                    }
                    Console.WriteLine(String.Join(" ", party)); return;
                }
                if (s[0]=="Add filter")
                {
                    predicate.Add(s);
                }
                else
                {
                    for (int i = 0; i < predicate.Count; i++) //who made this shitty language
                    {
                        if (predicate[i][1] == s[1] && predicate[i][2] == s[2])
                        {
                            predicate.RemoveAt(i);
                        }
                    }
                }
            }
        }
    }
}
