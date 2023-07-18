namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine(); //fuck you to whoever came up with this
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            DirectoryInfo dir = new DirectoryInfo(inputFolderPath);
            List<FileInfo> files = dir.GetFiles("*.*", SearchOption.TopDirectoryOnly).ToList();
            var fileswithext = new Dictionary<string, Dictionary<string, double>>();
            foreach (FileInfo file in files)
            {
                string[] s = file.Name.Split('.');
                if (!fileswithext.ContainsKey(s[1]))
                {
                    fileswithext.Add(s[1], new Dictionary<string, double>());
                }
                fileswithext[s[1]].Add(file.Name, file.Length / 1024);
            }
            string final = null;
            foreach (var ext in fileswithext.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                final += $".{ext.Key}";
                foreach (var file in fileswithext[ext.Key].OrderBy(x => x.Value))
                {
                    final += $"--{file.Key} - {file.Value}kb";
                }
            }
            return final;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName, textContent);
        }
    }
}
