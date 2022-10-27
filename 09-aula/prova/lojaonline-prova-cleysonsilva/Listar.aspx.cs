using ExercEventos.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace lojaonline_prova_cleysonsilva
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["error"] != null) return;

            Object id = Session["id"];
            Object nome = Session["nomeusuario"];

            if (id == null || nome == null)
            {
                Response.Redirect("Index.aspx?error=Não foi possível autenticar o usuário!", false);
                return;
            }


            try
            {

                MySqlConnection connection = ConnectionHelper.getMySqlConnection();

                String sql = "";
                sql += "SELECT idprod AS 'Código do produto', nomeprod AS 'Nome', preco AS 'Preço', nomecategoria AS 'Categoria' ";
                sql += "FROM produtos ";
                sql += "INNER JOIN categorias ON categorias.idcategoria=produtos.idcategoria ";

                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Prepare();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                gvProdutos.DataSource = dataTable;
                gvProdutos.DataBind();

                command.Dispose();
            }
            catch (Exception ex)
            {
                Response.Redirect($"Listar.aspx?error={ex.Message}", false);
            }
        }

    }
}