namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            File.Create(outputFilePath).Close();
            string[] s1 = File.ReadAllText(firstInputFilePath).Split(Environment.NewLine);
            string[] s2 = File.ReadAllText(secondInputFilePath).Split(Environment.NewLine);
            for (int i = 0; i < Math.Max(s1.Length, s2.Length); i++)
            {
                if (i<s1.Length&&i<s2.Length)
                {
                    File.AppendAllText(outputFilePath, s1[i] + Environment.NewLine + s2[i] + Environment.NewLine);
                }
                else if (i<s1.Length)
                {
                    File.AppendAllText(outputFilePath, s1[i]);
                    if (i!=s1.Length-1)
                    {
                        File.AppendAllText(outputFilePath, Environment.NewLine);
                    }
                }
                else if (i<s2.Length)
                {
                    File.AppendAllText(outputFilePath, s2[i]);
                    if (i != s2.Length - 1)
                    {
                        File.AppendAllText(outputFilePath, Environment.NewLine);
                    }
                }
            }
        }
    }
}
