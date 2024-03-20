using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class DataHandler
    {
        public static void ConnectDatabase()
        {
            manager = new MySqlHandler();
            manager.Connect();
        }

        private static DatabaseManager manager;
    }
}
