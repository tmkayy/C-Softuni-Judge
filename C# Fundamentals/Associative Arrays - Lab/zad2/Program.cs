using System;
using System.Collections.Generic;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].ToLower();
            }
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (string word in input)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count.Add(word, 1);
                }
            }
            foreach (KeyValuePair<string, int> thing in count)
            {
                if (thing.Value%2==1)
                {
                    Console.Write($"{thing.Key} ");
                }
            }
        }
    }
}
