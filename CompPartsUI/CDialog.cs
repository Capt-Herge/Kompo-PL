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
using PartsUI.AddItem;
using PartsLogic.Support;


namespace PartsUI
{
    public partial class CDialog : Form
    {
        #region fields
        private Part _partModify;
        private Part _partAdd;
        private Part _partSearch;
        #endregion

        #region properties
        internal Part PartModify { get { return _partModify; } }
        internal Part PartAdd { get { return _partAdd; } }
        internal Part PartSearch { get { return _partSearch; } }

        internal CDialogSearch DialogSearch { get; set; }
        internal CDialogSearchResult DialogSearchResult { get; set; }
        internal CDialogModify CDialogModify { get; set; }
        internal CDialogAddItem CDialogAddItem { get; set; }
        #endregion

        #region ctor
        public CDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region event handler
        // Eventhandler Lagerbestand anzeigen
        private void lagerbestandAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // Eventhandler Suche
        private void sucheToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // Eventhandler Neues Teil anlegen
        private void neuesTeilAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
