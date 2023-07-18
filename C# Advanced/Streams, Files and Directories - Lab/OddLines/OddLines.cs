namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader r = new StreamReader(inputFilePath, true);
            int br = 0;
            StreamWriter w = new StreamWriter(outputFilePath, false);
            while (true)
            {
                string s = r.ReadLine();
                if (s == null)
                {
                    r.Close();
                    w.Close();
                    return;
                }
                if (br % 2 != 0)
                {
                    w.WriteLine(s);
                }
                br++;
            }
        }
    }
}
