using System;
using System.Data;
using System.Windows.Forms;
using PartsLogic;


namespace PartsUI.Search
{
    public partial class CDialogSearchResult : Form
    {
        #region fields
        private CDialog _dialog;
        #endregion

        #region properties
        internal DataTable ResultTable { get; set; }
        #endregion

        #region ctor
        public CDialogSearchResult(IDialog dialog)
        {
            InitializeComponent();
            _dialog = dialog as CDialog;
        }
        #endregion

        #region events
        // Eventhandler Zurück zum Menü
        private void zurückZumMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        // Eventhandler Neue Suche
        private void neueSucheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #region methods
        private void CDialogSearchResult_Load(object sender, EventArgs e)
        {
            this.dg_suchergebnis.DataSource = ResultTable;

            foreach(DataGridViewColumn column in this.dg_suchergebnis.Columns)
            {
                if(column.Name.Substring(0,2) == "ID")
                {
                    column.Visible = false;
                }
            }

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dg_suchergebnis.Columns.Add(btn);
            btn.HeaderText = "Bearbeiten";
            btn.Text = "+";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            foreach(DataGridViewColumn dataGridViewColumn in this.dg_suchergebnis.Columns)
            {
                dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void dg_suchergebnis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
                // Mit ID zu Modify übergeben
            }
        }
        #endregion
    }
}
