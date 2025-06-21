using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementsystem.Data
{
    internal static class Dbconfing
    {
        private static string connectionstring = "Data Source=UnicomTIC.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionstring);
            conn.Open();
            return conn;
        }

    }
}
