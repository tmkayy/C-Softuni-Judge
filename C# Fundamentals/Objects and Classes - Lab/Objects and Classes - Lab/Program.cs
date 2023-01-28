using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_and_Classes___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> sentence = Console.ReadLine().Split(' ').ToList();
            for (int i = 0; i < sentence.Count; i++)
            {
                int r = new Random().Next(0, sentence.Count);
                Console.WriteLine(sentence[r]);
                sentence.RemoveAt(r);
                i--;
            }
        }
    }
}
