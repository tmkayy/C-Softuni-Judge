namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            StreamReader r1 = new StreamReader(wordsFilePath, false);
            List<string> words = r1.ReadLine().Split(' ').ToList();
            r1.Close();
            StreamReader r2 = new StreamReader(textFilePath, false);
            char[] sep = { ' ', ',', '.', '?','/', ';', '!', '-', '\n', '\r' };
            string[] s = r2.ReadToEnd().Split(sep, StringSplitOptions.RemoveEmptyEntries);
            r2.Close();
            Dictionary<string, int> d = new Dictionary<string, int>();
            for (int i = 0; i < words.Count; i++)
            {
                d.Add(words[i], 0);
                foreach (var item in s)
                {
                    if (item.ToLower() == words[i])
                    {
                        d[words[i]]++;
                    }
                }
            }
            StreamWriter w = new StreamWriter(outputFilePath, false);
            foreach (var item in d.OrderByDescending(x=>x.Value))
            {
                w.WriteLine($"{item.Key} - {item.Value}");
            }
            w.Close();
        }
    }
}
