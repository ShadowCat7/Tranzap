using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace TranzapServer
{
    public static class Authenticator
    {
        /// <summary>
        /// Reads from the user database file.
        /// </summary>
        private static StreamReader reader;

        /// <summary>
        /// Validates user info.
        /// </summary>
        /// <param name="name">The name of the user to validate.</param>
        /// <param name="password">The password of the user to validate.</param>
        /// <returns>Returns true if validation succeeds.</returns>
        public static bool checkUser(string name, string password)
        {
            bool gotInfo = false;
            while (!gotInfo)
            {
                try
                {
                    if (File.Exists("user_db"))
                    {
                        reader = new StreamReader("user_db");
                        while (!reader.EndOfStream)
                        {
                            if (reader.ReadLine() == name && reader.ReadLine() == password)
                            { return true; }
                        }
                        reader.Close();
                        gotInfo = true;
                    }
                    else
                    { return false; }
                }
                catch (IOException) { }
            }
            return false;
        }
    }
}
