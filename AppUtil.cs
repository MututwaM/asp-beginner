//using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdemo
{
    public class AppUtil
    {
        public static string className = "AppUtil";

        public static MySqlConnection DBConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["REMOTE_DB_CONNECTION"].ConnectionString;

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }

    }
}
