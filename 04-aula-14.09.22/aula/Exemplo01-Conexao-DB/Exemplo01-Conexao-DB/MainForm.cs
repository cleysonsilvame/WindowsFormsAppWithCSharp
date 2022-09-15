using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo01_Conexao_DB
{
    public partial class MainForm : Form
    {
        private MySqlConnection _conn;

        public MainForm()
        {
            InitializeComponent();

            string connStr = "server=localhost;user=root;database=escola;port=3306;password=root";
            _conn = new MySqlConnection(connStr);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _conn.Open();

            string sql = "SELECT * FROM CURSOS ORDER BY abrev";

            MySqlCommand command = new MySqlCommand(sql, _conn);

            
            MySqlDataReader reader = command.ExecuteReader();

            lbxCourses.Items.Clear();

            while (reader.Read())
            {
                lbxCourses.Items.Add(reader.GetString("abrev"));
            }



            _conn.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                String value = (String)lbxCourses.SelectedItem;

                String sql = "SELECT * FROM alunos WHERE curso=@curso";
                MySqlCommand command = new MySqlCommand(sql, _conn);
                command.Parameters.AddWithValue("curso", value);

                _conn.Open();

                MySqlDataReader reader = command.ExecuteReader();

                lbxStudents.Items.Clear();
                while (reader.Read())
                { 
                    lbxStudents.Items.Add(reader.GetString("nome"));
                }

                if (lbxStudents.Items.Count == 0)
                {
                    lbxStudents.Items.Add("Sem alunos encontrados!");

                }

                _conn.Close();

            }
            catch (Exception ex)
            {
                lbxStudents.Items.Clear();
                lbxStudents.Items.Add("Erro ao buscar os alunos. " + ex.Message);

            }
        }
    }
}
