using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PartsUI.Search;
using PartsUI.Modify;
using PartsUI.Add;
using PartsLogic.Support;
using PartsLogic;


namespace PartsUI
{
    internal partial class CDialog : Form, IDialog
    {
        #region fields
        private Part _partModify;
        private Part _partAdd;
        private Part _partSearch;
        private ILogic _logic;
        #endregion

        #region properties
        internal Part PartModify { get { return _partModify; } }
        internal Part PartAdd { get { return _partAdd; } }
        internal Part PartSearch { get { return _partSearch; } }

        internal CDialogSearch DialogSearch { get; set; }
        internal CDialogSearchResult DialogSearchResult { get; set; }
        internal CDialogModify CDialogModify { get; set; }
        internal CDialogAdd CDialogAdd { get; set; }
        #endregion

        #region ctor
        public CDialog(ILogic logic)
        {
            InitializeComponent();
            _logic = logic;
            _partModify = new Part();
            _partAdd = new Part();
            _partSearch = new Part();
        }
        #endregion

        #region events
        // Eventhandler Lagerbestand anzeigen
        private void lagerbestandAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Die Aktion musste leider abgebrochen werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Eventhandler Suche
        private void sucheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool loop = true;
                while(loop)
                {
                    DialogResult dialogResult = DialogSearch.ShowDialog();

                    if(dialogResult == DialogResult.OK)
                    {
                        _logic.Search.ReadParts(_partSearch, out DataTable dataTable);
                        DialogSearchResult.ResultTable = dataTable;
                        dialogResult = DialogSearchResult.ShowDialog();
                        if (dialogResult != DialogResult.OK)
                        {
                            loop = false;
                        }
                    }
                    else
                    {
                        loop = false;
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Die Aktion musste leider abgebrochen werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Eventhandler Neues Teil anlegen
        private void neuesTeilAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Die Aktion musste leider abgebrochen werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
