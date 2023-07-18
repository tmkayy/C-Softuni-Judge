namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            File.Create(outputFilePath).Close();
            string[] s = File.ReadAllLines(inputFilePath);
            for (int i = 0; i < s.Length; i++)
            {
                char[] c = s[i].ToCharArray();
                int br = 0; int br2 = 0;
                for (int j = 0;j < c.Length; j++)
                {
                    if (char.IsLetter(c[j]))
                    {
                        br++;
                    }
                    else if (char.IsPunctuation(c[j]))
                    {
                        br2++;
                    }
                }
                s[i] = $"Line {i+1}: " + String.Join(null, c) + $" ({br})({br2})";
            }
            File.WriteAllLines(outputFilePath, s);
        }
    }
}
