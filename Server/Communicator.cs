using System.IO;
using System.Net;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Collections;

namespace TranzapServer
{
    /// <summary>
    /// Uses threading to communicate with a client. Use in a list.
    /// </summary>
    public class Communicator
    {
        /// <summary>
        /// The client with whom the Communicator communicates.
        /// </summary>
        private System.Net.Sockets.TcpClient client;
        private string username;
        private string password;
        //TODO permissions
        /// <summary>
        /// Writes to the TCP stream of the client.
        /// </summary>
        private StreamWriter writer;
        /// <summary>
        /// Reads from the TCP stream of the client.
        /// </summary>
        private StreamReader reader;
        /// <summary>
        /// The thread through which the Communicator reads from the client.
        /// </summary>
        public Thread receiveMessage;
        private bool authenticated;

        /// <summary>
        /// Constructs a Communicator. Automatically starts a thread for receiving from the client.
        /// </summary>
        /// <param name="connection">A client for the Communicator to connect with.</param>
        public Communicator(System.Net.Sockets.TcpClient connection)
        {
            client = connection;
            writer = new StreamWriter(client.GetStream());
            reader = new StreamReader(client.GetStream());

            authenticated = false;

            username = "";
            password = "";

            receiveMessage = new Thread(new ThreadStart(getMessage));
            receiveMessage.IsBackground = true;
        }
        /// <summary>
        /// Called to receive a message. Loops forever.
        /// </summary>
        private void getMessage()
        {
            while (true)
            {
                try
                {
                    //TODO
                    if (reader.EndOfStream)
                    {
                        client.Close();
                        receiveMessage.Abort();
                    }
                }
                catch (IOException)
                { client.Close(); }
                catch (ObjectDisposedException)
                { reader.Dispose(); }
            }
        }
        public void sendMessage(List<string> message)
        {
            for (int i = 0; i < message.Count; i++)
            { writer.WriteLine(message[i]); }
            writer.Flush();
        }
        public void receiveUserDetails()
        {
            try
            {
                //if (!reader.EndOfStream)
                //{
                    if (!authenticated)
                    {
                        username = reader.ReadLine();
                        password = reader.ReadLine();
                    }
                //}
                else
                { client.Close(); }
            }
            catch (IOException)
            { client.Close(); }
        }
        public bool connected()
        { return client.Connected; }
        public string getUsername()
        { return username; }
        public string getPassword()
        { return password; }
        public bool getAuthenticated()
        { return authenticated; }
        public void setAuthenticated(bool value)
        {
            if (authenticated != true && value == true)
            { authenticated = value; }
        }
    }
}