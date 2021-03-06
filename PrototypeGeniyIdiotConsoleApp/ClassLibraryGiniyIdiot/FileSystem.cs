﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;


namespace ClassLibraryGiniyIdiot
{
    public class FileSystem
    {
         public static string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        public static void SaveString(string value, string fileName, bool append = true)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName), append))
            { outputFile.WriteLine(value); }
        }
        public static string GetString(string fileName)
        {
            using (StreamReader outputFile = new StreamReader(Path.Combine(docPath, fileName)))
            { return outputFile.ReadToEnd(); }
        }
        public static bool IsExist(string fileName)
        {
           return File.Exists(Path.Combine(docPath, fileName));
        }
        public static void CreateFile(string fileName)
        {
            using (File.Create(Path.Combine(docPath, fileName)))
            { }
        }
        public static void CleanFile(string fileName)
        {
            File.WriteAllText(Path.Combine(docPath, fileName), string.Empty);
        }
        public static string Serialize(object value)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
           return JsonSerializer.Serialize(value, options);
        }
    }
}
