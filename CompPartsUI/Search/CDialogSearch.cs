using System;
using System.Windows.Forms;
using PartsLogic;
using PartsLogic.Support;

namespace PartsUI.Search
{
    internal partial class CDialogSearch : Form
    {
        #region fields
        private CDialog _dialog;
        private ILogicSearch _logicSearch;
        #endregion

        #region ctor
        internal CDialogSearch(ILogicSearch logicSearch, IDialog dialog)
        {
            InitializeComponent();
            _dialog = dialog as CDialog;
            _logicSearch = logicSearch;
        }
        #endregion

        #region events
        // Eventhandler Zurück zum Menü
        private void zurückZumMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        // Eventhandler Abbrechen
        private void btn_abbrechen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        // Eventhandler Suchen
        private void btn_suchen_Click(object sender, EventArgs e)
        {
            Part partSearch = _dialog.PartSearch;
            partSearch.Hersteller = cb_hersteller.Text;
            partSearch.Name = tb_name.Text;
            partSearch.PN = tb_pn.Text;
            partSearch.Beschreibung = tb_beschreibung.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //Eventhandler Laden
        private void CDialogSearch_Load(object sender, EventArgs e)
        {
            if(cb_hersteller.SelectedIndex == -1)
            {
                cb_hersteller.Items.Clear();
                cb_hersteller.Items.AddRange(_dialog.Hersteller);
                if(cb_hersteller.Items.Count > 0)
                {
                    cb_hersteller.Text = cb_hersteller.Items[0].ToString();
                }
            }
        }

        #endregion
    }
}
