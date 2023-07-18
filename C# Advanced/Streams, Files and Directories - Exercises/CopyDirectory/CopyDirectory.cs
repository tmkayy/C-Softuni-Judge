namespace CopyDirectory
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            Directory.Delete(outputPath); Directory.CreateDirectory(outputPath);
            DirectoryInfo dir = new DirectoryInfo(inputPath);
            List<FileInfo> files = dir.GetFiles("*.*", SearchOption.TopDirectoryOnly).ToList();
            foreach (FileInfo file in files)
            {
                File.Copy(file.FullName, outputPath, true);
            }
        }
    }
}
