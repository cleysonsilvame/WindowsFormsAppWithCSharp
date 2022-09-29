using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DBAlunos
{
    public partial class Form1 : Form
    {
        private MySqlConnection _conn;

        public Form1()
        {
            InitializeComponent();

            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Server = "localhost";
            connBuilder.UserID = "root";
            connBuilder.Password = "root";
            connBuilder.Database = "universidade";
            connBuilder.Port = 3306;

            bool includeCredentials = true;

            _conn = new MySqlConnection(connBuilder.GetConnectionString(includeCredentials));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _conn.Open();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "INSERT INTO alunos VALUES (@id, @nome, @curso)";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", txtId.Text);
                command.Parameters.AddWithValue("nome", txtNome.Text);
                command.Parameters.AddWithValue("curso", txtCurso.Text);


                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Erro ao cadastrar um aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtId.Clear();
                    txtNome.Clear();
                    txtCurso.Clear();
                }




                command.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "SELECT * FROM alunos WHERE id=@id";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", txtId.Text);
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Aluno não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    txtNome.Text = reader.GetString("nome");
                    txtCurso.Text = reader.GetString("curso");
                }




                command.Dispose();
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "UPDATE alunos SET nome=@nome, curso=@curso WHERE id=@id";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", txtId.Text);
                command.Parameters.AddWithValue("nome", txtNome.Text);
                command.Parameters.AddWithValue("curso", txtCurso.Text);


                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Aluno não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Aluno atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtId.Clear();
                    txtNome.Clear();
                    txtCurso.Clear();
                }



                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "DELETE FROM alunos WHERE id=@id";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", txtId.Text);
                command.Parameters.AddWithValue("nome", txtNome.Text);
                command.Parameters.AddWithValue("curso", txtCurso.Text);


                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Aluno não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Aluno deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtId.Clear();
                    txtNome.Clear();
                    txtCurso.Clear();
                }



                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
