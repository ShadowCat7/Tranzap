﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

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

        public static bool connected()
        { return tcpClient.Connected; }
        public static string getName()
        { return name; }
        public static string getPassword()
        { return password; }
    }
}
