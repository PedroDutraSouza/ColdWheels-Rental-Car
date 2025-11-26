using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdWheels
{
    public static class Db
    {
        private static string _connString = "Server=localhost;Database=coldwheels;Uid=root;";


        public static MySqlConnection GetConnection()
        {
            var c = new MySqlConnection(_connString);
            c.Open();
            return c;
        }
    }
}
