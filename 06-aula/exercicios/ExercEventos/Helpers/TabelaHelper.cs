using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ExercEventos
{
    internal class TabelaHelper
    {
        private readonly string _table;
        private readonly MySqlConnection _connection;

        public TabelaHelper(string table, MySqlConnection connection)
        {
            this._table = table;
            this._connection = connection;
        }

        public string RowId { get; private set; }
        public bool IsSelectedRowId { get; private set; }

        public void Show()
        {
            string sql = $"SELECT * FROM {_table}";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, _connection);
            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, _table);

            Tabela tabelaForm = new Tabela(dataSet, _table);
            DialogResult result = tabelaForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                RowId = tabelaForm.rowId;
                IsSelectedRowId = true;
            }
        }
    }
}
