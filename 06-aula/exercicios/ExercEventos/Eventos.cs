using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ExercEventos
{
    public partial class Eventos : Form
    {
        private const string TABLE = "eventos";
        private readonly MySqlConnection _conn;

        public Eventos(MySqlConnectionStringBuilder connectionsBuilder)
        {
            InitializeComponent();           

            bool includeCredentials = true;

            _conn = new MySqlConnection(connectionsBuilder.GetConnectionString(includeCredentials));
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
                String sql = $"INSERT INTO {TABLE} VALUES (@id, @evento, @data_inicio, @data_fim, @local, @valor)";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", txtID.Text);
                command.Parameters.AddWithValue("evento", txtEvento.Text);
                command.Parameters.AddWithValue("data_inicio", txtDataInicio.Text);
                command.Parameters.AddWithValue("data_fim", txtDataTermino.Text);
                command.Parameters.AddWithValue("local", txtLocal.Text);
                command.Parameters.AddWithValue("valor", txtValor.Text);

                command.Prepare();

                if (command.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Não foi possível adicionar o evento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Evento adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            selectEventosById(txtID.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = $"UPDATE {TABLE} SET id_evento=@id, evento=@evento, data_inicio=@data_inicio, data_termino=@data_fim, local=@local, valor=@valor WHERE id_evento=@id";
                MySqlCommand command = new MySqlCommand(sql, _conn);

                command.Parameters.AddWithValue("id", txtID.Text);
                command.Parameters.AddWithValue("evento", txtEvento.Text);
                command.Parameters.AddWithValue("data_inicio", txtDataInicio.Text);
                command.Parameters.AddWithValue("data_fim", txtDataTermino.Text);
                command.Parameters.AddWithValue("local", txtLocal.Text);
                command.Parameters.AddWithValue("valor", txtValor.Text);


                if (command.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Não foi possível atualizar o evento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Evento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                String sql = $"DELETE FROM {TABLE} WHERE id_evento=@id";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", txtID.Text);


                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Evento não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Evento deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                selectEventosById(helper.RowId);
            }

        }

        private void selectEventosById(string id)
        {
            try
            {
                String sql = $"SELECT * FROM {TABLE} WHERE id_evento=@id";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", id);

                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Evento não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtID.Text = reader.GetString("id_evento");
                    txtEvento.Text = reader.GetString("evento");
                    txtDataInicio.Text = reader.GetString("data_inicio");
                    txtDataTermino.Text = reader.GetString("data_termino");
                    txtLocal.Text = reader.GetString("local");
                    txtValor.Text = reader.GetString("valor").Replace(",", ".");
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
