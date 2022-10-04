using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercEventos
{
    public partial class Eventos : Form
    {
        private readonly MySqlConnection _conn;

        public Eventos()
        {
            InitializeComponent();

            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Server = "localhost";
            connBuilder.UserID = "root";
            connBuilder.Password = "root";
            connBuilder.Database = "sistema_teds";
            connBuilder.Port = 3306;

            bool includeCredentials = true;

            _conn = new MySqlConnection(connBuilder.GetConnectionString(includeCredentials));
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            _conn.Open();
        }


        private void Eventos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _conn.Close();
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    String sql = "SELECT * FROM alunos WHERE id=@id";
            //    MySqlCommand command = new MySqlCommand(sql, _conn);
            //    command.Parameters.AddWithValue("id", txtId.Text);
            //    MySqlDataReader reader = command.ExecuteReader();

            //    if (!reader.Read())
            //    {
            //        MessageBox.Show("Aluno não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {

            //        txtNome.Text = reader.GetString("nome");
            //        txtCurso.Text = reader.GetString("curso");
            //    }




            //    command.Dispose();
            //    reader.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    String sql = "UPDATE alunos SET nome=@nome, curso=@curso WHERE id=@id";
            //    MySqlCommand command = new MySqlCommand(sql, _conn);
            //    command.Parameters.AddWithValue("id", txtId.Text);
            //    command.Parameters.AddWithValue("nome", txtNome.Text);
            //    command.Parameters.AddWithValue("curso", txtCurso.Text);


            //    if (command.ExecuteNonQuery() == 0)
            //    {
            //        MessageBox.Show("Aluno não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Aluno atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        txtId.Clear();
            //        txtNome.Clear();
            //        txtCurso.Clear();
            //    }



            //    command.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    String sql = "DELETE FROM alunos WHERE id=@id";
            //    MySqlCommand command = new MySqlCommand(sql, _conn);
            //    command.Parameters.AddWithValue("id", txtId.Text);
            //    command.Parameters.AddWithValue("nome", txtNome.Text);
            //    command.Parameters.AddWithValue("curso", txtCurso.Text);


            //    if (command.ExecuteNonQuery() == 0)
            //    {
            //        MessageBox.Show("Aluno não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Aluno deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        txtId.Clear();
            //        txtNome.Clear();
            //        txtCurso.Clear();
            //    }



            //    command.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

    }
}
