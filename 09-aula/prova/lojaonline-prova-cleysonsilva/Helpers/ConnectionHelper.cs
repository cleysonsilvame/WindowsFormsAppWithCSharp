using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercEventos.Helpers
{
    internal class ConnectionHelper
    {

        public static MySqlConnection getMySqlConnection()
        {

            MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "root",
                Database = "lojaonline",
                Port = 3306,
                SslMode = MySqlSslMode.Disabled
            };

            bool includeCredentials = true;

            MySqlConnection connection = new MySqlConnection(stringBuilder.GetConnectionString(includeCredentials));

            connection.Open();

            return connection;
        }
    }
}
