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
            FileManager.checkAllFiles();

            string consoleText = getServerInfo(server);

            int count = 0;
            string command = "";
            string tempCommand = "";
            string qualifyingText = "";
            ConsoleKeyInfo keys = new ConsoleKeyInfo();
            while (command != "quit")
            {
                if (command != "")
                {
                    if (checkCommand("quit", command, ref tempCommand))
                    {
                        if (tempCommand == "")
                        { qualifyingText = "Goodbye."; }
                        else if (tempCommand == "help")
                        { qualifyingText = "Usage: quit | Closes the console."; }
                        else
                        { qualifyingText = "Not a valid command. Type help for more information."; }
                    }
                    else if (checkCommand("help", command, ref tempCommand))
                    {
                        if (tempCommand == "")
                        { qualifyingText = "Usage: -command- help | Commands: QUIT, HELP, UPLOAD"; }
                        else if (tempCommand == "help")
                        { qualifyingText = "You must think you're pretty funny."; }
                        else 
                        { qualifyingText = "Not a valid command. Type help for more information.";}
                    }
                    else if (checkCommand("upload", command, ref tempCommand))
                    {
                        if (tempCommand == "help")
                        { qualifyingText = "Usage: upload -file path- | Uploads the designated file."; }
                        else
                        {
                            if (FileManager.fileExists(tempCommand))
                            {
                                FileManager.uploadFile(tempCommand);
                                qualifyingText = "File uploaded.";
                            }
                            else
                            { qualifyingText = "That file does not exist there."; }
                        }
                    }
                    else
                    { qualifyingText = "Not a valid command. Type help for more information."; }

                    tempCommand = "";
                    command = "";
                }

                writeServerInfo(server, qualifyingText, tempCommand);

                //Let's get server info while we wait for a key.
                while (Console.KeyAvailable == false)
                {
                    string tempString = getServerInfo(server);
                    if (consoleText != tempString)
                    { writeServerInfo(server, qualifyingText, tempCommand); }
                }
                keys = Console.ReadKey(true);

                //Special keys.
                if (keys.Key == ConsoleKey.Enter)
                {
                    command = tempCommand;
                    tempCommand = "";
                }
                else if (keys.Key == ConsoleKey.Backspace && tempCommand.Length > 0)
                {
                    string temp = "";
                    for (int i = 0; i < tempCommand.Length - 1; i++)
                    { temp += tempCommand[i]; }
                    tempCommand = temp;
                }
                else if (keys.Key == ConsoleKey.Delete)
                { }
                else
                { tempCommand += keys.KeyChar.ToString(); }
            }
        }

        static void writeServerInfo(Server server, string qualifyingText, string userCommand)
        {
            string consoleText = getServerInfo(server);
            Console.Clear();
            Console.WriteLine(consoleText);
            Console.CursorTop = Console.WindowHeight - 2;
            Console.WriteLine(qualifyingText);
            Console.Write(userCommand);
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

        static bool checkCommand(string command, string toCheck, ref string left)
        {
            left = "";
            string tempString = "";
            for (int i = 0; i < toCheck.Length; i++)
            {
                tempString += toCheck[i];
                if (tempString == command)
                {
                    i += 2;
                    while (i < toCheck.Length)
                    {
                        left += toCheck[i];
                        i++;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
