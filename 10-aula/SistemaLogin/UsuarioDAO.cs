using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace SistemaLogin
{
    public class UsuarioDAO
    {
        public string validaUsuario(Usuario usuario)
        {
            SqlConnection connection = Conecta.getConexao();
            string sql = "SELECT * FROM usuarios WHERE login=@login and senha=@senha";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("login", usuario.Login);
            cmd.Parameters.AddWithValue("senha", usuario.Senha);

            var reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {

                throw new Exception("Usuário não encontrado!");
            }

            reader.Read();

            reader.Close();
            cmd.Dispose();

            return reader["id"].ToString();
        }

        public void salvarUsuario(Usuario usuario)
        {

            SqlConnection connection = Conecta.getConexao();
            string sql = "INSERT INTO usuarios VALUES(null, @login, @senha)";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("id", usuario.Id);
            cmd.Parameters.AddWithValue("login", usuario.Login);
            cmd.Parameters.AddWithValue("senha", usuario.Senha);

            int linhas = cmd.ExecuteNonQuery();

            if (linhas <= 0)
            {
                throw new Exception("Não foi possível salvar o usuário");
            }
        }
    }
}