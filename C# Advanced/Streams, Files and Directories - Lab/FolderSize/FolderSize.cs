namespace FolderSize
{
    using System;
    using System.IO;
    using System.Linq;

    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            FileInfo[] howdidigettothelastzad = dir.GetFiles("*.*" , SearchOption.AllDirectories);
            //long size = howdidigettothelastzad.Select(x => x.Length).Sum() / 1000;
            double sum = 0;
            for (int i = 0; i < howdidigettothelastzad.Length; i++)
            {
                sum += howdidigettothelastzad[i].Length;
            }
            StreamWriter w = new StreamWriter(outputFilePath);
            w.Write(sum/1000); w.Close();
        }
    }
}
