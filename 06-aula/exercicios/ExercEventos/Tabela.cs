using System;
using System.Data;
using System.Windows.Forms;

namespace ExercEventos
{
    public partial class Tabela : Form
    {
        private readonly DataSet _dataSet;
        private readonly string _table;

        public string rowId { get; private set; }

        public Tabela(DataSet dataSet, string table)
        {
            InitializeComponent();
            this._dataSet = dataSet;
            this._table = table;
        }

        private void Tabela_Load(object sender, EventArgs e)
        {
            dgvTabela.DataSource = _dataSet;
            dgvTabela.DataMember = _table;



            int dgv_width = dgvTabela.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            int dgv_height = dgvTabela.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

            this.Width = dgv_width + 65;
            this.Height = dgv_height + 65;
        }


        private void dgvTabela_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var cells = dgvTabela.Rows[e.RowIndex].Cells;

                rowId = cells[0].Value.ToString();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
