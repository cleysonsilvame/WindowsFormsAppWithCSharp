using ExercEventos.Helpers;
using System;
using System.Windows.Forms;

namespace ExercEventos
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eventos eventosForm = new Eventos(ConnectionHelper.GetConnectionsBuilder);
            closeOrShowMainForm(eventosForm.ShowDialog());
        }

        private void btnInstituicoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instituicoes instituicoesForm = new Instituicoes(ConnectionHelper.GetConnectionsBuilder);
            closeOrShowMainForm(instituicoesForm.ShowDialog());
        }

        private void closeOrShowMainForm(DialogResult result)
        {
            if (result == DialogResult.Cancel)
                this.DestroyHandle();
            else
                this.Show();
        }
    }
}
