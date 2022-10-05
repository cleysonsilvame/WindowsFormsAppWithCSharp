using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ExercEventos
{
    public partial class Instituicoes : Form
    {
        private const string TABLE = "instituicoes";
        private readonly MySqlConnection _conn;

        public Instituicoes(MySqlConnectionStringBuilder connectionBuilder)
        {
            InitializeComponent();

            bool includeCredentials = true;

            _conn = new MySqlConnection(connectionBuilder.GetConnectionString(includeCredentials));
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
            try
            {
                String sql = $"INSERT INTO {TABLE} VALUES (@id, @nome, @cidade, @uf)";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", txtID.Text);
                command.Parameters.AddWithValue("nome", txtNome.Text);
                command.Parameters.AddWithValue("cidade", txtCidade.Text);
                command.Parameters.AddWithValue("uf", txtUF.Text);

                command.Prepare();

                if (command.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Não foi possível adicionar a instituição", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Instituição adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InterfaceHelper.ClearAllTextBoxs(pnlnfo.Controls);
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
            selectInstituicoesById(txtID.Text);
        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = $"UPDATE {TABLE} SET id_instituicao=@id, nm_instituicao=@nome, ds_cidade=@cidade, ds_uf=@uf WHERE id_instituicao=@id";

                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", txtID.Text);
                command.Parameters.AddWithValue("nome", txtNome.Text);
                command.Parameters.AddWithValue("cidade", txtCidade.Text);
                command.Parameters.AddWithValue("uf", txtUF.Text);


                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Instituição não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Instituição atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InterfaceHelper.ClearAllTextBoxs(pnlnfo.Controls);
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
                String sql = $"DELETE FROM {TABLE} WHERE id_instituicao=@id";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", txtID.Text);


                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Instituição não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Instituição deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InterfaceHelper.ClearAllTextBoxs(pnlnfo.Controls);
                }



                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            var helper = new TabelaHelper(TABLE, _conn);

            helper.Show();

            if (helper.IsSelectedRowId)
            {
                selectInstituicoesById(helper.RowId);
            }
        }

        private void selectInstituicoesById(string id)
        {
            try
            {
                String sql = $"SELECT * FROM {TABLE} WHERE id_instituicao=@id";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", id);
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Instituição não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtID.Text = reader.GetString("id_instituicao");
                    txtNome.Text = reader.GetString("nm_instituicao");
                    txtCidade.Text = reader.GetString("ds_cidade");
                    txtUF.Text = reader.GetString("ds_uf");
                }

                command.Dispose();
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}
