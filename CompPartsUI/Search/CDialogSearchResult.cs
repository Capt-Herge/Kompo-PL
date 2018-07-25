using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartsUI.Search
{
    public partial class CDialogSearchResult : Form
    {
        #region fields
        #endregion

        #region ctor
        #endregion

        #region events
        public CDialogSearchResult()
        {
            InitializeComponent();
        }

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
    }
}
