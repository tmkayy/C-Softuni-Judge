namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader r = new StreamReader(inputFilePath, false);
            StreamWriter w = new StreamWriter(outputFilePath, false);
            int i = 1;
            while (!r.EndOfStream)
            {
                w.WriteLine($"{i}. {r.ReadLine()}");
                i++;
            }
            r.Close();
            w.Close();
        }
    }
}
