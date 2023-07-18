namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] idkwhatimdoing = File.ReadAllBytes(sourceFilePath);
            File.Create(partOneFilePath).Close(); File.Create(partTwoFilePath).Close();
            FileInfo WHYISTHISASEPERATECLASS = new FileInfo(sourceFilePath);
            BinaryWriter itssohotinthisroom = new BinaryWriter(WHYISTHISASEPERATECLASS.OpenWrite());
            if (WHYISTHISASEPERATECLASS.Length % 2 == 0)
            {
                for (long i = 0; i < WHYISTHISASEPERATECLASS.Length / 2; i++)
                {
                    itssohotinthisroom.Write(idkwhatimdoing[i]);
                }
                for (long i = WHYISTHISASEPERATECLASS.Length / 2; i < WHYISTHISASEPERATECLASS.Length; i++)
                {
                    itssohotinthisroom.Write(idkwhatimdoing[i]);
                }
            }
            else
            {
                for (long i = 0; i < WHYISTHISASEPERATECLASS.Length / 2 + 1; i++)
                {
                    itssohotinthisroom.Write(idkwhatimdoing[i]);
                }
                for (long i = WHYISTHISASEPERATECLASS.Length / 2 + 1; i < WHYISTHISASEPERATECLASS.Length; i++)
                {
                    itssohotinthisroom.Write(idkwhatimdoing[i]);
                }
            }
            itssohotinthisroom.Close();
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            File.Create(partTwoFilePath).Close(); //WHY IS THERE A SECOND METHOD IN HERE
            byte[] thankgodforYT = File.ReadAllBytes(partOneFilePath);
            byte[] shoutouttomyniggaDerek = File.ReadAllBytes(partTwoFilePath);
            FileInfo fij = new FileInfo(joinedFilePath);
            BinaryWriter bwj = new BinaryWriter(fij.OpenWrite());
            for (int i = 0; i < thankgodforYT.Length; i++)
            {
                bwj.Write(thankgodforYT[i]);
            }
            for (int i = 0; i < shoutouttomyniggaDerek.Length; i++)
            {
                bwj.Write(shoutouttomyniggaDerek[i]);
            }
        }
        //NO WAY THIS SHIT WORKED FIRST TRY AHHHAHAAHAHAH
    }
}