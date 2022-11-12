using System;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Vowels(word);
        }
        static void Vowels(string word)
        {
            int br = 0;
            word = word.ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]=='a'|| word[i] == 'o'|| word[i] == 'u'|| word[i] == 'e'|| word[i] == 'i')
                {
                    br++;
                }
            }
            Console.WriteLine(br);
        }
    }
}
