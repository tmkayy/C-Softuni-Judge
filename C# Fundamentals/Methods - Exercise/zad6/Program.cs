using System;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleChar(word);
        }
        static void MiddleChar (string word)
        {
            if (word.Length%2==0)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word.Length / 2 -1 == i)
                    {
                        Console.Write(word[i]);
                    }
                    if (word.Length / 2 == i)
                    {
                        Console.Write(word[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word.Length / 2 == i)
                    {
                        Console.Write(word[i]);
                    }
                }
            }
        }
    }
}
