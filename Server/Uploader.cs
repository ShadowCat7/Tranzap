using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TranzapServer
{
    public static class FileManager
    {
        private static StreamReader reader;
        private static Object locker = new object();

        public static bool fileExists(string fileName)
        { return File.Exists("downloads/" + fileName); }

        public static List<string> getFile(string fileName)
        {
            lock (locker)
            {
                List<string> fileContents = new List<string>();
                reader = new StreamReader("downloads/" + fileName);
                while (!reader.EndOfStream)
                { fileContents.Add(reader.ReadLine()); }
                return fileContents;
            }
        }
    }
}
