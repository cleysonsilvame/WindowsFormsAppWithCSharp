using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaLogin
{
    public class Conecta
    {

        public static SqlConnection getConexao()
        {
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\autologon\Documents\aulas-teds-4-semestre-unicsul\10-aula\SistemaLogin\App_Data\login.mdf;Integrated Security=True";

            SqlConnection conexao = new SqlConnection(connectionString);
            
            conexao.Open();

            return conexao;
        }
    }
}