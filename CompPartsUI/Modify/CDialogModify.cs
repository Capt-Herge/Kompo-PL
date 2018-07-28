using System;
using System.Windows.Forms;
using PartsLogic;
using PartsLogic.Support;

namespace PartsUI.Modify
{
    internal partial class CDialogModify : Form
    {
        #region fields
        private CDialog _dialog;
        private ILogicModify _logicModify;
        #endregion

        #region ctor
        internal CDialogModify(ILogicModify logicModify, IDialog dialog)
        {
            InitializeComponent();
            _dialog = dialog as CDialog;
            _logicModify = logicModify;
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
        // Eventhandler Speichern
        private void btn_speichern_Click(object sender, EventArgs e)
        {

            Part partModify = _dialog.PartModify;
            //Sanity-Check der Werte
            if (tb_name.Text == "")
            {
                MessageBox.Show("Das Feld \"Name\" darf nicht leer bleiben!", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tb_hersteller.Text == "")
            {
                MessageBox.Show("Das Feld \"Hersteller\" darf nicht leer bleiben!", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tb_pn.Text == "")
            {
                MessageBox.Show("Das Feld \"Teilenummer\" darf nicht leer bleiben!", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tb_preis.Text == "")
            {
                MessageBox.Show("Das Feld \"Preis\" darf nicht leer bleiben!", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tb_preis.Text == "")
            {
                MessageBox.Show("Das Feld \"Anzahl\" darf nicht leer bleiben!", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Schreiben der aktualisierten Werte in die partModify
            partModify.Name = tb_name.Text;
            partModify.Hersteller = tb_hersteller.Text;
            partModify.Beschreibung = tb_beschreibung.Text;
            partModify.PN = tb_pn.Text;
            partModify.Anzahl = Conversions.ParseInt(tb_anzahl.Text);
            partModify.Preis = tb_preis.Text;
            //Schreiben der partModify in die Datenbank
            if (partModify.Anzahl == 0)
            {
                //Bei erreichen einer Anzahl von 0: Nachfragen ob Part direkt geköscht werden soll
                DialogResult dialogResult = MessageBox.Show("Die Anzahl der verbleibenden Autoteile ist jetzt 0. \n Soll der Eintrag jetzt gelöscht werden?", "Autoteil vergiffen", MessageBoxButtons.YesNo);
                //Fall JA --> Löschen und schließen
                if (dialogResult == DialogResult.Yes)
                {
                    _logicModify.DeletePart(partModify);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                //Fall Nein --> Ändern und schließen
                else if (dialogResult == DialogResult.No)
                {
                    _logicModify.ModifyPart(partModify);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                //Alles andere(annahmsweise Abbruch) --> Nur zurück zur DialogModify Form
                else
                {
                    return;
                }
            }
            //Speichern des geänderten Parts
            _logicModify.ModifyPart(partModify);
            //Rückgabe des Endzustandes und schließen
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        // Eventhandler Laden
        private void CDialogModify_Load_1(object sender, EventArgs e)
        {
            //Befüllen des Lokalen partModify mit dem aus dem Hauptdialog
            Part partModify = _dialog.PartModify;
            //Befüllen der Textboxen anhand der Werte im partModify
            tb_name.Text = partModify.Name;
            tb_hersteller.Text = partModify.Hersteller;
            tb_beschreibung.Text = partModify.Beschreibung;
            tb_pn.Text = partModify.PN;
            tb_preis.Text = partModify.Preis;
            tb_anzahl.Text = partModify.Anzahl.ToString();
            // Wenn Anzahl des Parts 0 ist, Löschen-Button anzeigen
            if(partModify.Anzahl == 0)
            {
                btn_loeschen.Visible = true;
            }
            else
            {
                btn_loeschen.Visible = false;
            }
        }

        // Eventhandler Löschen
        private void btn_loeschen_Click(object sender, EventArgs e)
        {
            Part partModify = _dialog.PartModify;
            //Löschen des Parts
            _logicModify.DeletePart(partModify);
            //Endzustandsweitergabe und schließen des Dialogs
            this.DialogResult = DialogResult.OK;
            this.Close();
            return;
        }

        // Eventhandler Eigabe bei Preis
        private void tb_preis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //Prüfen auf Punkt oder Komma
            char sepratorChar = 's';
            //Prüfen bei Eingabe eines Punktes/Kommas, ob dies noch erlaubt ist
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //Fälle in denen die Eingabe nicht angenommen wird
                //1. Punkt/Komma am Anfang
                if (tb_preis.Text.Length == 0) e.Handled = true;
                if (tb_preis.SelectionStart == 0) e.Handled = true;
                //2.Es existiert bereits ein Punkt/Komma
                if (alreadyExist(tb_preis.Text, ref sepratorChar)) e.Handled = true;
                //3.Punkt/Komma in der Mitte einer Zahl, die danach nicht größer als 99 sein darf
                if (tb_preis.SelectionStart != tb_preis.Text.Length && e.Handled == false)
                {
                    //Punkt/Komma ist in der Mitte
                    string AfterDotString = tb_preis.Text.Substring(tb_preis.SelectionStart);
                    //Ziffern danach < 2
                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }

            //Prüfen auf Ziffer
            if (Char.IsDigit(e.KeyChar))
            {
                //Prüfen of bereits ein Punkt/Komma existiert
                if (alreadyExist(tb_preis.Text, ref sepratorChar))
                {
                    int sepratorPosition = tb_preis.Text.IndexOf(sepratorChar);
                    string afterSepratorString = tb_preis.Text.Substring(sepratorPosition + 1);
                    if (tb_preis.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        //Eventhandler Eingabe Anzahl
        private void tb_anzahl_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nur Zahlen erlauben
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region methods
        //Hilfsmethode für den Input-Check beim Preis
        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }
        #endregion
    }
}
