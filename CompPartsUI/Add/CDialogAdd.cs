using System;
using System.Windows.Forms;
using PartsLogic;
using PartsLogic.Support;

namespace PartsUI.Add
{
    internal partial class CDialogAdd : Form
    {
        #region fields
        private CDialog _dialog;
        private ILogicAdd _logicAdd;
        #endregion

        #region ctor
        internal CDialogAdd(ILogicAdd logicAdd, IDialog dialog)
        {
            InitializeComponent();
            _dialog = dialog as CDialog;
            _logicAdd = logicAdd;
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
        // Eventhandler Anlegen
        private void btn_anlegen_Click(object sender, EventArgs e)
        {


            Part partAdd = _dialog.PartAdd;
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
            //Pop-Up Wenn Anzahl 0 Erreicht nach Änderung
            //Schreiben der aktualisierten Werte in die partModify
            partAdd.Name = tb_name.Text;
            partAdd.Hersteller = tb_hersteller.Text;
            partAdd.Beschreibung = tb_beschreibung.Text;
            partAdd.PN = tb_pn.Text;
            partAdd.Anzahl = Conversions.ParseInt(tb_anzahl.Text);
            partAdd.Preis = tb_preis.Text;
            //Schreiben der partModify in die Datenbank
            _logicAdd.AddPart(partAdd);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        // Eventhandler Eingabe in Preis -- Beschränken auf Zahl mit einem Punkt/Komma und zwei Stellen dahinter
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  (e.KeyChar != '.'))
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
