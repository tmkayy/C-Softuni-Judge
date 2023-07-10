using System;
using System.Collections.Generic;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>(); //dedicated to the haters
            for (int i = 0; i < n; i++)
            {
                string[] sep = { " -> ", "," };
                string[] s = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (clothes.ContainsKey(s[0]))
                {
                    for (int j = 1; j < s.Length; j++)
                    {
                        if (clothes[s[0]].ContainsKey(s[j]))
                        {
                            clothes[s[0]][s[j]]++;
                        }
                        else
                        {
                            clothes[s[0]].Add(s[j], 1);
                        }
                    }
                }
                else
                {
                    clothes.Add(s[0], new Dictionary<string, int>());
                    for (int j = 1; j < s.Length; j++)
                    {
                        if (clothes[s[0]].ContainsKey(s[j]))
                        {
                            clothes[s[0]][s[j]]++;
                        }
                        else
                        {
                            clothes[s[0]].Add(s[j], 1);
                        }
                    }
                }
            }
            string[] search = Console.ReadLine().Split(' ');
            foreach (var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var item2 in item.Value)
                {
                    if (item.Key == search[0] && item2.Key == search[1])
                    {
                        Console.WriteLine($"* {item2.Key} - {item2.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item2.Key} - {item2.Value}");
                    }
                }
            }
        }
    }
}
