﻿using System;
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
    public partial class CDialogSearch : Form
    {
        #region fields
        #endregion

        #region ctor
        #endregion

        #region events
        public CDialogSearch()
        {
            InitializeComponent();
        }

        // Eventhandler Zurück zum Menü
        private void zurückZumMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
