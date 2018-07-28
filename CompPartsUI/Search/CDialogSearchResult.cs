using System;
using System.Data;
using System.Windows.Forms;
using PartsLogic;
using PartsLogic.Support;


namespace PartsUI.Search
{
    public partial class CDialogSearchResult : Form
    {
        #region fields
        private CDialog _dialog;
        #endregion

        #region properties
        internal DataTable ResultTable { get; set; }
        internal ToolStripMenuItem MenuNeueSuche { get; set; }
        #endregion

        #region ctor
        public CDialogSearchResult(IDialog dialog)
        {
            InitializeComponent();
            _dialog = dialog as CDialog;
            MenuNeueSuche = neueSucheToolStripMenuItem;
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
        // Eventhanlder Laden
        private void CDialogSearchResult_Load(object sender, EventArgs e)
        {
            dg_suchergebnis.Columns.Clear();

            this.dg_suchergebnis.DataSource = ResultTable;
            //Verstecken der ID-Column
            foreach(DataGridViewColumn column in this.dg_suchergebnis.Columns)
            {
                if(column.Name.Substring(0,2) == "ID")
                {
                    column.Visible = false;
                }
            }
            //Erstellen der Bearbeiten-Button Column -- Überprüfen, ob sie bereits da ist, sonst existierst sie mehrfach
            int existTest = 0;
            foreach(DataGridViewColumn column in this.dg_suchergebnis.Columns)
            {
                if(column.Name == "btn")
                {
                    existTest++;
                }
            }
            if(!(existTest > 0))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dg_suchergebnis.Columns.Add(btn);
                btn.HeaderText = "Bearbeiten";
                btn.Text = "+";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
            }
            //Setzten des AutoSizeColumn Modes für alle Columns
            foreach(DataGridViewColumn dataGridViewColumn in this.dg_suchergebnis.Columns)
            {
                dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }
        // Eventhalnder Button in DataGridView
        private void dg_suchergebnis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dg_suchergebnis.Columns[e.ColumnIndex].Name == "btn")
            {
                // Schreiben der Werte des Parts
                Part partModify = _dialog.PartModify;
                partModify.PkID = Conversions.ParseInt(dg_suchergebnis.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                partModify.Hersteller = dg_suchergebnis.Rows[e.RowIndex].Cells["Hersteller"].Value.ToString();
                partModify.Name = dg_suchergebnis.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                partModify.PN = dg_suchergebnis.Rows[e.RowIndex].Cells["PN"].Value.ToString();
                partModify.Beschreibung = dg_suchergebnis.Rows[e.RowIndex].Cells["Beschreibung"].Value.ToString();
                partModify.Preis = dg_suchergebnis.Rows[e.RowIndex].Cells["Preis"].Value.ToString();
                partModify.Anzahl = Conversions.ParseInt(dg_suchergebnis.Rows[e.RowIndex].Cells["Anzahl"].Value.ToString());
                
                //Ja wir missbrauchen hier ein DialogResult 
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
        #endregion
    }
}
