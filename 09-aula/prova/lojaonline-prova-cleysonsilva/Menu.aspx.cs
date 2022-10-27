using ExercEventos.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lojaonline_prova_cleysonsilva
{
    public partial class Menu : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["error"] != null) return;

            Object id = Session["id"];
            Object nome = Session["nomeusuario"];

            if (id == null ||  nome == null)
            {
                Response.Redirect("Index.aspx?error=Não foi possível autenticar o usuário!", false);
                return;
            }


            

            try
            {
                MySqlConnection connection = ConnectionHelper.getMySqlConnection();

                String sql = "";
                sql += "SELECT idproduto AS 'Código do produto', nomeprod AS 'Nome do produto', qtdecomprada AS 'Quantidade que comprou' ";
                sql += "FROM comprasefetuadas ";
                sql += "INNER JOIN produtos ON produtos.idprod=comprasefetuadas.idproduto ";
                sql += "WHERE idusuario=@id";

                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("id", id);


                command.Prepare();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                gvProdutosComprados.DataSource = dataTable;
                gvProdutosComprados.DataBind();

                command.Dispose();
            }
            catch (Exception ex)
            {
                Response.Redirect($"Menu.aspx?error={ex.Message}", false);
            }
        }
    }
}