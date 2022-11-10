using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtLogin.Text, txtSenha.Text);

            try
            {
                new UsuarioDAO().validaUsuario(usuario);
                Response.Redirect("Produto.aspx");
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }

        }
    }
}