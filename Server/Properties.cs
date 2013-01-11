using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TranzapServer
{
    public static class Properties
    {
        private static bool permissions;

        public static void getPermissions()
        {
            if (!File.Exists("properties"))
            {
                File.Create("properties").Close();
                //TODO
            }

            StreamReader reader = new StreamReader("properties");
            //permissions = Convert.ToBoolean(reader.ReadLine());

            reader.Close();
        }
    }
}
