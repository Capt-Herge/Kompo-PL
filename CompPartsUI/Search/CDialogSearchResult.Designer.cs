namespace PartsUI.Search
{
    partial class CDialogSearchResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zurückZumMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueSucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dg_suchergebnis = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_suchergebnis)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zurückZumMenüToolStripMenuItem,
            this.neueSucheToolStripMenuItem});
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
            // neueSucheToolStripMenuItem
            // 
            this.neueSucheToolStripMenuItem.Name = "neueSucheToolStripMenuItem";
            this.neueSucheToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.neueSucheToolStripMenuItem.Text = "Neue Suche";
            this.neueSucheToolStripMenuItem.Click += new System.EventHandler(this.neueSucheToolStripMenuItem_Click);
            // 
            // dg_suchergebnis
            // 
            this.dg_suchergebnis.AllowUserToAddRows = false;
            this.dg_suchergebnis.AllowUserToDeleteRows = false;
            this.dg_suchergebnis.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dg_suchergebnis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_suchergebnis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_suchergebnis.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dg_suchergebnis.Location = new System.Drawing.Point(0, 24);
            this.dg_suchergebnis.Margin = new System.Windows.Forms.Padding(0);
            this.dg_suchergebnis.Name = "dg_suchergebnis";
            this.dg_suchergebnis.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dg_suchergebnis.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_suchergebnis.Size = new System.Drawing.Size(1008, 705);
            this.dg_suchergebnis.TabIndex = 0;
            this.dg_suchergebnis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_suchergebnis_CellClick);
            // 
            // CDialogSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dg_suchergebnis);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "CDialogSearchResult";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Suchergebnis";
            this.Load += new System.EventHandler(this.CDialogSearchResult_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_suchergebnis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zurückZumMenüToolStripMenuItem;
        private System.Windows.Forms.DataGridView dg_suchergebnis;
        private System.Windows.Forms.ToolStripMenuItem neueSucheToolStripMenuItem;
    }
}