using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercEventos.Helpers
{
    internal class ConnectionHelper
    {

        public static MySqlConnectionStringBuilder GetConnectionsBuilder => new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "root",
            Database = "sistema_teds",
            Port = 3306
        };
    }
}
