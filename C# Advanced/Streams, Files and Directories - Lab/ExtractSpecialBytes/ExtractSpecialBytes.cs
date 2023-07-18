namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            File.Create(outputPath).Close();
            byte[] bytes = File.ReadAllBytes(binaryFilePath);
            var listwithbytes = new List<string>(File.ReadAllLines(bytesFilePath));
            string outputshitidk = null;
            foreach (var item in bytes)
            {
                if (listwithbytes.Contains(item.ToString()))
                {
                    outputshitidk += item.ToString();
                }
            }
            File.WriteAllText(outputPath, outputshitidk.Trim());
        }
    }
}
