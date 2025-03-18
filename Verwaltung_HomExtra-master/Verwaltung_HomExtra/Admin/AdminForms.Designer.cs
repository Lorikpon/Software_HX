namespace Verwaltung_HomExtra
{
    partial class AdminForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmdRechnungErstellen = new System.Windows.Forms.Button();
            this.cmdRechnungAendern = new System.Windows.Forms.Button();
            this.cmdRechnungLoeschen = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dgvVertrieb = new System.Windows.Forms.DataGridView();
            this.cmbRolle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVertrieb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administration der Benutzer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 549);
            this.panel2.TabIndex = 1;
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(549, 462);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(120, 22);
            this.txtPasswort.TabIndex = 103;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 98;
            this.label10.Text = "Passwort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 93;
            this.label4.Text = "Benutzername:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 92;
            this.label3.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(549, 390);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 22);
            this.txtID.TabIndex = 91;
            // 
            // cmdRechnungErstellen
            // 
            this.cmdRechnungErstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRechnungErstellen.Location = new System.Drawing.Point(255, 551);
            this.cmdRechnungErstellen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRechnungErstellen.Name = "cmdRechnungErstellen";
            this.cmdRechnungErstellen.Size = new System.Drawing.Size(172, 38);
            this.cmdRechnungErstellen.TabIndex = 86;
            this.cmdRechnungErstellen.Text = "User jetzt erstellen!";
            this.cmdRechnungErstellen.UseVisualStyleBackColor = true;
            this.cmdRechnungErstellen.Click += new System.EventHandler(this.cmdRechnungErstellen_Click);
            // 
            // cmdRechnungAendern
            // 
            this.cmdRechnungAendern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRechnungAendern.Location = new System.Drawing.Point(519, 551);
            this.cmdRechnungAendern.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRechnungAendern.Name = "cmdRechnungAendern";
            this.cmdRechnungAendern.Size = new System.Drawing.Size(172, 37);
            this.cmdRechnungAendern.TabIndex = 84;
            this.cmdRechnungAendern.Text = "User jetzt ändern!";
            this.cmdRechnungAendern.UseVisualStyleBackColor = true;
            this.cmdRechnungAendern.Click += new System.EventHandler(this.cmdRechnungAendern_Click);
            // 
            // cmdRechnungLoeschen
            // 
            this.cmdRechnungLoeschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRechnungLoeschen.Location = new System.Drawing.Point(775, 550);
            this.cmdRechnungLoeschen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRechnungLoeschen.Name = "cmdRechnungLoeschen";
            this.cmdRechnungLoeschen.Size = new System.Drawing.Size(172, 38);
            this.cmdRechnungLoeschen.TabIndex = 85;
            this.cmdRechnungLoeschen.Text = "Benutzer jetzt löschen!";
            this.cmdRechnungLoeschen.UseVisualStyleBackColor = true;
            this.cmdRechnungLoeschen.Click += new System.EventHandler(this.cmdRechnungLoeschen_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(549, 429);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(120, 22);
            this.txtUsername.TabIndex = 87;
            // 
            // dgvVertrieb
            // 
            this.dgvVertrieb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVertrieb.Location = new System.Drawing.Point(176, 66);
            this.dgvVertrieb.Name = "dgvVertrieb";
            this.dgvVertrieb.RowHeadersWidth = 51;
            this.dgvVertrieb.RowTemplate.Height = 24;
            this.dgvVertrieb.Size = new System.Drawing.Size(891, 297);
            this.dgvVertrieb.TabIndex = 82;
            this.dgvVertrieb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVertrieb_CellContentClick);
            // 
            // cmbRolle
            // 
            this.cmbRolle.FormattingEnabled = true;
            this.cmbRolle.Items.AddRange(new object[] {
            "Mitarbeiter",
            "Abteilungsleiter",
            "Admin"});
            this.cmbRolle.Location = new System.Drawing.Point(549, 491);
            this.cmbRolle.Name = "cmbRolle";
            this.cmbRolle.Size = new System.Drawing.Size(121, 24);
            this.cmbRolle.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "Rolle:";
            // 
            // chbPass
            // 
            this.chbPass.AutoSize = true;
            this.chbPass.Location = new System.Drawing.Point(704, 463);
            this.chbPass.Name = "chbPass";
            this.chbPass.Size = new System.Drawing.Size(142, 20);
            this.chbPass.TabIndex = 106;
            this.chbPass.Text = "Passwort anzeigen";
            this.chbPass.UseVisualStyleBackColor = true;
            this.chbPass.CheckedChanged += new System.EventHandler(this.chbPass_CheckedChanged);
            // 
            // AdminForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.chbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRolle);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cmdRechnungErstellen);
            this.Controls.Add(this.cmdRechnungAendern);
            this.Controls.Add(this.cmdRechnungLoeschen);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dgvVertrieb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVertrieb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button cmdRechnungErstellen;
        private System.Windows.Forms.Button cmdRechnungAendern;
        private System.Windows.Forms.Button cmdRechnungLoeschen;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DataGridView dgvVertrieb;
        private System.Windows.Forms.ComboBox cmbRolle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbPass;
    }
}