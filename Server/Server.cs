using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace TranzapServer
{
    /// <summary>
    /// The server. Sets up everything.
    /// </summary>
    class Server
    {
        private TcpListener tcpListener;
        private string lanAddress;
        private string extAddress;
        private string domain;

        private List<Communicator> users;

        private Thread addUserThread;

        public Server()
        {
            lanAddress = getLANIP();
            extAddress = getExtIP();

            IPAddress addr = IPAddress.Parse(extAddress);
            IPHostEntry entry = Dns.GetHostEntry(addr);
            domain = entry.HostName;

            tcpListener = new TcpListener(IPAddress.Parse(lanAddress), 28369);
            tcpListener.Start();

            users = new List<Communicator>();

            addUserThread = new Thread(new ThreadStart(addUsers));
            addUserThread.IsBackground = true;
            addUserThread.Start();
        }

        private void addUsers()
        {
            while (true)
            {
                if (tcpListener.Pending())
                {
                    TcpClient pendingClient = tcpListener.AcceptTcpClient();

                    Communicator pendingUser = new Communicator(pendingClient);

                    while (!pendingUser.getAuthenticated() && pendingUser.connected())
                    {
                        if (Authenticator.checkUser(pendingUser.getUsername(), pendingUser.getPassword()))
                        {
                            pendingUser.setAuthenticated(true);
                            List<string> acceptance = new List<string>();
                            acceptance.Add("log in accepted");
                            pendingUser.sendMessage(acceptance);
                        }
                        else
                        { pendingUser.receiveUserDetails(); }
                    }

                    if (pendingUser.connected())
                    { users.Add(pendingUser); }
                }
            }
        }

        private string getLANIP()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                { localIP = ip.ToString(); }
            }
            return localIP;
        }
        private string getExtIP()
        {
            WebRequest request = WebRequest.Create("http://www.jsonip.com/");
            WebResponse response = request.GetResponse(); //TODO
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string webString = reader.ReadToEnd();
            string ipString = "";
            for (int i = 0; i < webString.Length; i++)
            {
                if (webString[i] == ':')
                {
                    i += 2;
                    while (webString[i] != '"')
                    {
                        ipString += webString[i];
                        i++;
                    }
                    i = webString.Length;
                }
            }
            return ipString;
        }
        public string getLanAddress()
        { return lanAddress; }
        public string getExtAddress()
        { return extAddress; }
        public string getDomainName()
        { return domain; }
        public int getUserCount()
        { return users.Count; }
    }
}
