using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            var v1 = Convert.ToSingle(txtValor1.Text);
            var v2 = Convert.ToSingle(txtValor2.Text);

            if (this.dblOpcoes.SelectedValue == "Somar")
            {
                var resultado = v1 + v2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
            else if (this.dblOpcoes.SelectedValue == "Subtrair")
            {
                var resultado = v1 - v2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
            else if (this.dblOpcoes.SelectedValue == "Multiplicar")
            {
                var resultado = v1 * v2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
            else if (this.dblOpcoes.SelectedValue == "Dividir")
            {
                var resultado = v1 / v2;
                lblResultado.Text = $"Resultado: {resultado}";
            } else
            {
                lblResultado.Text = "Resultado: ";
            }
        }
    }
}