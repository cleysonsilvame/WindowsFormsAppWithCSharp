using ExercEventos.Helpers;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lojaonline_prova_cleysonsilva
{
    public partial class Autentica : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            String username = Request.Params["username"];
            String password = Request.Params["password"];


            try
            {

                MySqlConnection connection = ConnectionHelper.getMySqlConnection();

                String sql = "SELECT idusuario, nomeusuario FROM usuarios WHERE nomeusuario=@username AND senhausuario=@password";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);

                command.Prepare();

                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    Response.Redirect("Index.aspx?error=Nenhum usuário encontrado.", false);
                }
                else
                {
                    Session["id"] = reader.GetInt32("idusuario");
                    Session["nomeusuario"] = reader.GetString("nomeusuario");
                    Response.Redirect("Menu.aspx", false);
                }

                reader.Close();
                reader.Dispose();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Response.Redirect($"Index.aspx?error={ex.Message}", false);
            }
        }


    }
}