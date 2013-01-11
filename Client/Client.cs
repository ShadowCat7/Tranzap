using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Tranzap
{
    public static class Client
    {
        private static TcpClient tcpClient = new TcpClient();
        private static StreamWriter writer;
        private static StreamReader reader;

        private static string name;
        private static string password;

        private static bool loggedIn = false;

        public static Thread receiveMessage;

        public static bool connect(string address)
        {
            IPAddress ipAddress;
            if (IPAddress.TryParse(address, out ipAddress))
            {
                try
                { tcpClient.Connect(ipAddress, 28369); }
                catch { }
            }
            else
            {
                try
                { tcpClient.Connect(address, 28369); }
                catch { }
            }
            if (tcpClient.Connected)
            {
                writer = new StreamWriter(tcpClient.GetStream());
                reader = new StreamReader(tcpClient.GetStream());
                return true;
            }
            else
            { return false; }
        }

        public static bool logIn(string tempName, string tempPassword)
        {
            if (!loggedIn)
            {
                List<string> userDetails = new List<string>();
                userDetails.Add(tempName);
                userDetails.Add(tempPassword);
                writeMessage(userDetails);
                if (reader.ReadLine() == "log in accepted")
                {
                    name = tempName;
                    password = tempPassword;
                    loggedIn = true;

                    receiveMessage = new Thread(new ThreadStart(readMessage));
                    receiveMessage.IsBackground = true;
                    receiveMessage.Start();

                    return true;
                }
                return false;
            }
            else
            { return true; }
        }

        public static void writeMessage(List<string> message)
        {
            for (int i = 0; i < message.Count; i++)
            { writer.WriteLine(message[i]); }
            writer.Flush();
        }

        private static void readMessage()
        {
            while (true)
            {
                List<string> message = new List<string>();
                try
                {
                    message.Add(reader.ReadLine());
                    if (reader.EndOfStream)
                    {
                        //client.Close(); TODO
                        receiveMessage.Abort();
                    }
                }
                catch (IOException)
                { //client.Close(); TODO
                }
                catch (ObjectDisposedException)
                { reader.Dispose(); }

                if (message.Count > 0)
                {
                    if (message[0] == "download incoming")
                    {
                        message.Add(reader.ReadLine());
                        message.Add(reader.ReadLine());
                        for (int i = 0; i < Convert.ToInt32(message[2]); i++)
                        { message.Add(reader.ReadLine()); }
                        FileManager.saveFile(message);
                    }
                }
            }
        }

        public static bool connected()
        { return tcpClient.Connected; }
        public static string getName()
        { return name; }
        public static string getPassword()
        { return password; }
        public static bool getLoggedIn()
        { return loggedIn; }
    }
}
