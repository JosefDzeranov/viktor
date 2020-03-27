using System;
using System.IO;


namespace GeniyIdiot.Common
{
    public class FileSystem
    {
        public static string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static void SaveString(string value, string fileName)
        {
            using (StreamWriter outputFile = File.AppendText(Path.Combine(docPath, fileName)))
            {
                outputFile.WriteLine(value);
            }
        }
        public static string GetString(string fileName)
        {
            using (StreamReader outputFile = new StreamReader(Path.Combine(docPath, fileName)))
            {
                return outputFile.ReadToEnd();
            }
        }

        public static bool IsExists(string fileName)
        {
            return File.Exists(Path.Combine(docPath, fileName));
        }
    }
}
