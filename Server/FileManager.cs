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
        private static StreamWriter writer;
        private static Object locker = new object();

        public static bool fileExists(string fileName)
        { return File.Exists(fileName); }

        public static void checkAllFiles()
        {
            if (File.Exists("uploads/upload_list"))
            {
                reader = new StreamReader("uploads/upload_list");
                List<string> uploadList = new List<string>();

                while (!reader.EndOfStream)
                {
                    string tempString = reader.ReadLine();
                    if (File.Exists("uploads/" + tempString))
                    { uploadList.Add(tempString); }
                }
                reader.Close();
                writer = new StreamWriter("uploads/upload_list");
                for (int i = 0; i < uploadList.Count; i++)
                { writer.WriteLine(uploadList[i]); }
            }
        }

        public static List<string> listFiles()
        {
            if (File.Exists("uploads/upload_list"))
            {
                List<string> fileList = new List<string>();

                reader = new StreamReader("uploads/upload_list");
                while (!reader.EndOfStream)
                { fileList.Add(reader.ReadLine()); }
                reader.Close();
                //TODO missing files.
                return fileList;
            }
            else
            {
                File.Create("uploads/upload_list").Close();
                return new List<string>();
            }
        }

        public static void saveFile(List<string> fileContents)
        {
            if (File.Exists("uploads/" + fileContents[1]))
            {
                //TODO
            }
            else
            {
                File.Create("uploads/" + fileContents[1]).Close();
                writer = new StreamWriter("uploads/" + fileContents[1]);
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
                reader = new StreamReader("uploads/" + fileName);
                while (!reader.EndOfStream)
                { fileContents.Add(reader.ReadLine()); }
                reader.Close();
                return fileContents;
            }
        }

        //Server-only code. TODO uploading files changes them (must find out how).
        public static void uploadFile(string filePath)
        {
            string fileName = Path.GetFileName(filePath);
            reader = new StreamReader(filePath);
            writer = new StreamWriter("uploads/" + fileName);
            writer.AutoFlush = true;
            while (!reader.EndOfStream)
            { writer.WriteLine(reader.ReadLine()); }
            reader.Close();
            writer.Close();

            writer = new StreamWriter("uploads/upload_list", true);
            writer.WriteLine(fileName);
            writer.Close();
        }
    }
}
