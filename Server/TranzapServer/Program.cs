using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranzapServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            Console.Title = "TranzapServer";

            getServerInfo(server);

            int count = 0;
            string command = "";
            while (command != "quit")
            {
                //TODO
                if (count == 10)
                { getServerInfo(server); }
            }
        }

        static void getServerInfo(Server server)
        {
            Console.Clear();

            Console.WriteLine("LAN IP Address: " + server.getLanAddress());
            Console.WriteLine("External IP Address: " + server.getExtAddress());
            Console.WriteLine("Domain: " + server.getDomainName());
            Console.WriteLine("Current User Count: " + server.getUserCount());

            Console.CursorTop = Console.WindowHeight;
        }
    }
}
