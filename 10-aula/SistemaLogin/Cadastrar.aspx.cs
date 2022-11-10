using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaLogin
{
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click1(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtLogin.Text, txtSenha.Text);

            try
            {
                new UsuarioDAO().salvarUsuario(usuario);

                Response.Redirect("Login.aspx");
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

    }
}