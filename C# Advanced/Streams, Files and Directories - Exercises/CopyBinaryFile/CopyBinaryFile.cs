namespace CopyBinaryFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            File.Create(outputFilePath).Close();
            FileStream fs = new FileStream(inputFilePath, FileMode.Open);
            FileStream fs2 = new FileStream(outputFilePath, FileMode.Open);
            byte[] b = new byte[256];
            while (true)
            {
                int bytes = fs.Read(b, 0, b.Length);
                if (bytes == 0)
                {
                    return;
                }
                fs2.Write(b, 0, bytes);
            }
        }
    }
}
