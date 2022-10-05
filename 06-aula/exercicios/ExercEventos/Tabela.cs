using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace ExercEventos
{
    public partial class Tabela : Form
    {
        private readonly DataSet _dataSet;
        private readonly string _table;

        private const string HELP_TEXT = "Clique em uma linha para selecionar!";

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

            int dgvWidth = dgvTabela.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            int dgvHeight = dgvTabela.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

            this.Width = dgvWidth + 65;
            this.Height = dgvHeight + 65;
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

        private void dgvTabela_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            var cell = dgvTabela.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            cell.ToolTipText = HELP_TEXT;
        }
    }
}
