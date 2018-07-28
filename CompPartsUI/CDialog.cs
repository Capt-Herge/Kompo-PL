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
        private object[] _arrayHersteller;
        #endregion

        #region properties
        //Fields Getter
        internal object[] Hersteller { get { return _arrayHersteller; } }
        internal Part PartModify { get { return _partModify; } }
        internal Part PartAdd { get { return _partAdd; } }
        internal Part PartSearch { get { return _partSearch; } }
        //Dialoge
        internal CDialogSearch DialogSearch { get; set; }
        internal CDialogSearchResult DialogSearchResult { get; set; }
        internal CDialogModify DialogModify { get; set; }
        internal CDialogAdd DialogAdd { get; set; }
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
                //Vorweg anlegen der DataTable
                DataTable dataTable;
                //Befülle einen Part mit nur leeren Parametern
                Part showAll = new Part();
                showAll.Hersteller = "";
                showAll.Name = "";
                showAll.PN = "";
                showAll.Beschreibung = "";
                //Führe die Suche auf "alles" aus
                _logic.Search.ReadParts(showAll, out  dataTable);
                //Schreibe Datatable zum DialogSearchResult
                DialogSearchResult.ResultTable = dataTable;
                //Wechsle zum DialogSearchResult
                DialogSearchResult.MenuNeueSuche.Visible = false;
                DialogResult dialogResult = DialogSearchResult.ShowDialog();
                //Leeren der lokalen DataTable
                dataTable.Clear();
                //Direkter Verweis von da aus zum DialogModify
                if (dialogResult == DialogResult.Yes)
                {
                    //Wechsel zu DialogModify
                    dialogResult = DialogModify.ShowDialog();
                }
                
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
                //Erstellen der Hersteller Liste für ComboBox
                _logic.GetHersteller(out _arrayHersteller);
                bool loop = true;
                //Schleife zum Wechseln zwischen den Suchen/Bearbeiten Dialogen
                while(loop)
                {
                    //Anzeigen des suchen Dialogs
                    DialogResult dialogResult = DialogSearch.ShowDialog();
                    //Bei Klick auf "Suchen" --> Wechsel zu DialogSearchResult
                    if(dialogResult == DialogResult.OK)
                    {
                        //DB Abfrage nach Suchparametern
                        _logic.Search.ReadParts(_partSearch, out DataTable dataTable);
                        //Schreiben des dataTables in das vorgesehenen Feld von DialogSearchResult
                        DialogSearchResult.ResultTable = dataTable;
                        //Anzeigen des DialogSearchresult
                        DialogSearchResult.MenuNeueSuche.Visible = true;
                        dialogResult = DialogSearchResult.ShowDialog();
                        //Entscheidungsbaum für Sprung aus DialogSearchResult
                        //Wenn Abbruch: Loop verlassen -> Zurück zum Hauptdialog
                        if (dialogResult != DialogResult.OK && dialogResult != DialogResult.Yes)
                        {
                            // Rückkehr zum Hauptdialog durch Austritt aus Schleife
                            loop = false;
                        }
                        //Wenn Click auf Bearbeiten Button --> Wechsel zum DialogModify
                        else if(dialogResult == DialogResult.Yes)
                        {
                            //Wechsel zu DialogModify
                            dialogResult = DialogModify.ShowDialog();
                            //Wenn wir hier fertig sind, wollen wir im Hauptdialog landen
                            loop = false;
                        }
                        //Wenn OK --> Wechsel zurück zum DialogSearch via Loop
                        else
                        {
                            //Nix zu tun
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
                DialogResult dialogResult = DialogAdd.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Die Aktion musste leider abgebrochen werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
