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

namespace Exemplo01_Conexao_DB
{
    public partial class Cadastrar : Form
    {
        private MySqlConnection _conn;

        public Cadastrar()
        {
            InitializeComponent();

            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Server = "localhost";
            connBuilder.UserID = "root";
            connBuilder.Password = "root";
            connBuilder.Database = "escola";
            connBuilder.Port = 3306;

            bool includeCredentials = true;

            _conn = new MySqlConnection(connBuilder.GetConnectionString(includeCredentials));

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {

                _conn.Open();

                String sql = "INSERT INTO cursos VALUES (@abrev, @nome)";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("abrev", txtAbrev.Text);
                command.Parameters.AddWithValue("nome", txtNomeCurso.Text);


                command.ExecuteNonQuery();


                txtAbrev.Clear();
                txtNomeCurso.Clear();


                MessageBox.Show("Curso Cadastrado com Sucesso!");

                txtAbrev.Focus();


                _conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
