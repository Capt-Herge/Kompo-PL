namespace PartsUI.Search
{
    partial class CDialogSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDialogSearch));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zurückZumMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_suchen = new System.Windows.Forms.Button();
            this.btn_abbrechen = new System.Windows.Forms.Button();
            this.tb_beschreibung = new System.Windows.Forms.TextBox();
            this.tb_pn = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_beschreibung = new System.Windows.Forms.Label();
            this.lbl_hersteller = new System.Windows.Forms.Label();
            this.lbl_pn = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pb_suche = new System.Windows.Forms.PictureBox();
            this.cb_hersteller = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_suche)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zurückZumMenüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zurückZumMenüToolStripMenuItem
            // 
            this.zurückZumMenüToolStripMenuItem.Name = "zurückZumMenüToolStripMenuItem";
            this.zurückZumMenüToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.zurückZumMenüToolStripMenuItem.Text = "Zurück zum Menü";
            this.zurückZumMenüToolStripMenuItem.Click += new System.EventHandler(this.zurückZumMenüToolStripMenuItem_Click);
            // 
            // btn_suchen
            // 
            this.btn_suchen.Font = new System.Drawing.Font("Lucida Console", 18F);
            this.btn_suchen.Location = new System.Drawing.Point(796, 667);
            this.btn_suchen.Name = "btn_suchen";
            this.btn_suchen.Size = new System.Drawing.Size(200, 50);
            this.btn_suchen.TabIndex = 28;
            this.btn_suchen.Text = "Suchen";
            this.btn_suchen.UseVisualStyleBackColor = true;
            this.btn_suchen.Click += new System.EventHandler(this.btn_suchen_Click);
            // 
            // btn_abbrechen
            // 
            this.btn_abbrechen.Font = new System.Drawing.Font("Lucida Console", 18F);
            this.btn_abbrechen.Location = new System.Drawing.Point(590, 667);
            this.btn_abbrechen.Name = "btn_abbrechen";
            this.btn_abbrechen.Size = new System.Drawing.Size(200, 50);
            this.btn_abbrechen.TabIndex = 27;
            this.btn_abbrechen.Text = "Abbrechen";
            this.btn_abbrechen.UseVisualStyleBackColor = true;
            this.btn_abbrechen.Click += new System.EventHandler(this.btn_abbrechen_Click);
            // 
            // tb_beschreibung
            // 
            this.tb_beschreibung.Location = new System.Drawing.Point(500, 375);
            this.tb_beschreibung.Name = "tb_beschreibung";
            this.tb_beschreibung.Size = new System.Drawing.Size(300, 20);
            this.tb_beschreibung.TabIndex = 25;
            // 
            // tb_pn
            // 
            this.tb_pn.Location = new System.Drawing.Point(40, 375);
            this.tb_pn.Name = "tb_pn";
            this.tb_pn.Size = new System.Drawing.Size(300, 20);
            this.tb_pn.TabIndex = 22;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(500, 275);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(300, 20);
            this.tb_name.TabIndex = 21;
            // 
            // lbl_beschreibung
            // 
            this.lbl_beschreibung.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lbl_beschreibung.Location = new System.Drawing.Point(500, 350);
            this.lbl_beschreibung.Name = "lbl_beschreibung";
            this.lbl_beschreibung.Size = new System.Drawing.Size(300, 25);
            this.lbl_beschreibung.TabIndex = 19;
            this.lbl_beschreibung.Text = "Beschreibung:";
            // 
            // lbl_hersteller
            // 
            this.lbl_hersteller.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lbl_hersteller.Location = new System.Drawing.Point(40, 250);
            this.lbl_hersteller.Name = "lbl_hersteller";
            this.lbl_hersteller.Size = new System.Drawing.Size(300, 25);
            this.lbl_hersteller.TabIndex = 18;
            this.lbl_hersteller.Text = "Hersteller:";
            // 
            // lbl_pn
            // 
            this.lbl_pn.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lbl_pn.Location = new System.Drawing.Point(40, 350);
            this.lbl_pn.Name = "lbl_pn";
            this.lbl_pn.Size = new System.Drawing.Size(300, 25);
            this.lbl_pn.TabIndex = 16;
            this.lbl_pn.Text = "Teilenummer (P/N):";
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lbl_name.Location = new System.Drawing.Point(500, 250);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(300, 25);
            this.lbl_name.TabIndex = 15;
            this.lbl_name.Text = "Name:";
            // 
            // pb_suche
            // 
            this.pb_suche.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_suche.BackgroundImage")));
            this.pb_suche.Location = new System.Drawing.Point(0, 24);
            this.pb_suche.Margin = new System.Windows.Forms.Padding(0);
            this.pb_suche.Name = "pb_suche";
            this.pb_suche.Size = new System.Drawing.Size(1008, 200);
            this.pb_suche.TabIndex = 29;
            this.pb_suche.TabStop = false;
            // 
            // cb_hersteller
            // 
            this.cb_hersteller.FormattingEnabled = true;
            this.cb_hersteller.Location = new System.Drawing.Point(40, 275);
            this.cb_hersteller.Name = "cb_hersteller";
            this.cb_hersteller.Size = new System.Drawing.Size(300, 21);
            this.cb_hersteller.TabIndex = 30;
            // 
            // CDialogSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.cb_hersteller);
            this.Controls.Add(this.pb_suche);
            this.Controls.Add(this.btn_suchen);
            this.Controls.Add(this.btn_abbrechen);
            this.Controls.Add(this.tb_beschreibung);
            this.Controls.Add(this.tb_pn);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_beschreibung);
            this.Controls.Add(this.lbl_hersteller);
            this.Controls.Add(this.lbl_pn);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "CDialogSearch";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Autoteil suchen";
            this.Load += new System.EventHandler(this.CDialogSearch_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_suche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zurückZumMenüToolStripMenuItem;
        private System.Windows.Forms.Button btn_suchen;
        private System.Windows.Forms.Button btn_abbrechen;
        private System.Windows.Forms.TextBox tb_beschreibung;
        private System.Windows.Forms.TextBox tb_pn;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_beschreibung;
        private System.Windows.Forms.Label lbl_hersteller;
        private System.Windows.Forms.Label lbl_pn;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pb_suche;
        private System.Windows.Forms.ComboBox cb_hersteller;
    }
}