namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StreamReader r = new StreamReader(inputFilePath, false);
            List<string> lines = new List<string>();
            char[] sep = { '-', ',', '.', '!', '?' }; int br = 0;
            while (!r.EndOfStream)
            {
                if (br%2==0)
                {
                    lines.Add(r.ReadLine());
                }
                br++;
            }
            List<string> final = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                string[] s = lines[i].Split(' ');
                s = s.Reverse().ToArray();
                char[] c = String.Join(" ", s).ToCharArray();
                for (int j = 0; j < c.Length; j++)
                {
                    if (sep.Contains(c[j]))
                    {
                        c[j] = '@';
                    }
                }
                final.Add(String.Join(null, c));
            }
            return String.Join(Environment.NewLine, final);
        }
    }
}
