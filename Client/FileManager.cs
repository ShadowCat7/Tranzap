using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tranzap
{
    public static class FileManager
    {
        private static StreamReader reader;
        private static StreamWriter writer;
        private static Object locker = new object();

        public static bool fileExists(string fileName)
        { return File.Exists("downloads/" + fileName); }

        public static List<string> listFiles()
        {
            if (File.Exists("downloads/download_list"))
            {
                List<string> fileList = new List<string>();

                reader = new StreamReader("downloads/download_list");
                while (!reader.EndOfStream)
                { fileList.Add(reader.ReadLine()); }
                reader.Close();
                //TODO missing files.
                return fileList;
            }
            else
            {
                File.Create("downloads/download_list").Close();
                return new List<string>();
            }
        }

        public static void saveFile(List<string> fileContents)
        {
            if (File.Exists("downloads/" + fileContents[1]))
            {
                //TODO
            }
            else
            {
                File.Create("downloads/" + fileContents[1]).Close();
                writer = new StreamWriter("downloads/" + fileContents[1]);
                writer.AutoFlush = true;
                for (int i = 3; i < fileContents.Count; i++)
                { writer.WriteLine(fileContents[i]); }
                writer.Close();
            }
        }

        public static List<string> getFile(string fileName)
        {
            lock (locker)
            {
                List<string> fileContents = new List<string>();
                reader = new StreamReader("downloads/" + fileName);
                while (!reader.EndOfStream)
                { fileContents.Add(reader.ReadLine()); }
                reader.Close();
                return fileContents;
            }
        }
    }
}
