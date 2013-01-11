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

            string consoleText = getServerInfo(server);
            Console.WriteLine(consoleText);
            Console.CursorTop = Console.WindowHeight - 1;

            int count = 0;
            string command = "";
            while (command != "quit")
            {
                string tempString = getServerInfo(server);
                if (consoleText != tempString)
                {
                    consoleText = tempString;
                    Console.Clear();
                    Console.WriteLine(consoleText);
                }
            }
        }

        static string getServerInfo(Server server)
        {
            string tempString =
                "LAN IP Address: " + server.getLanAddress() + "\n" +
                "External IP Address: " + server.getExtAddress() + "\n" +
                "Domain: " + server.getDomainName() + "\n" +
                "Current User Count: " + server.getUserCount();

            return tempString;
        }
    }
}
