using System;
using System.Windows.Forms;
using PartsLogic;
using PartsLogic.Support;

namespace PartsUI.Search
{
    public partial class CDialogSearch : Form
    {
        #region fields
        private CDialog _dialog;
        private ILogicSearch _logicSearch;
        #endregion

        #region ctor
        public CDialogSearch(ILogicSearch logicSearch, IDialog dialog)
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

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
    }
}
