namespace Verwaltung_HomExtra
{
    partial class Beschaffung
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFDat = new System.Windows.Forms.DateTimePicker();
            this.dtpEDat = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtBeschreibung = new System.Windows.Forms.TextBox();
            this.txtLieferant = new System.Windows.Forms.TextBox();
            this.cmdRechnungErstellen = new System.Windows.Forms.Button();
            this.cmdRechnungAendern = new System.Windows.Forms.Button();
            this.cmdRechnungLoeschen = new System.Windows.Forms.Button();
            this.txtBetragN = new System.Windows.Forms.TextBox();
            this.txtRNr = new System.Windows.Forms.TextBox();
            this.dgvBeschaffung = new System.Windows.Forms.DataGridView();
            this.panFiltern = new System.Windows.Forms.Panel();
            this.cmdBesFiltDel = new System.Windows.Forms.Button();
            this.cmdBesFiltern = new System.Windows.Forms.Button();
            this.cmdBesSuchen = new System.Windows.Forms.Button();
            this.txtUst = new System.Windows.Forms.TextBox();
            this.txtBetragB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMenge = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeschaffung)).BeginInit();
            this.panFiltern.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 63);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(922, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bild";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beschaffung";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtMenge);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBetragB);
            this.panel2.Controls.Add(this.txtUst);
            this.panel2.Controls.Add(this.dtpFDat);
            this.panel2.Controls.Add(this.dtpEDat);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.txtBeschreibung);
            this.panel2.Controls.Add(this.txtLieferant);
            this.panel2.Controls.Add(this.cmdRechnungErstellen);
            this.panel2.Controls.Add(this.cmdRechnungAendern);
            this.panel2.Controls.Add(this.cmdRechnungLoeschen);
            this.panel2.Controls.Add(this.txtBetragN);
            this.panel2.Controls.Add(this.txtRNr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 174);
            this.panel2.TabIndex = 1;
            // 
            // dtpFDat
            // 
            this.dtpFDat.Location = new System.Drawing.Point(206, 82);
            this.dtpFDat.Name = "dtpFDat";
            this.dtpFDat.Size = new System.Drawing.Size(200, 22);
            this.dtpFDat.TabIndex = 48;
            // 
            // dtpEDat
            // 
            this.dtpEDat.Location = new System.Drawing.Point(206, 54);
            this.dtpEDat.Name = "dtpEDat";
            this.dtpEDat.Size = new System.Drawing.Size(200, 22);
            this.dtpEDat.TabIndex = 47;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ueberfaellig",
            "faellig",
            "gezahlt"});
            this.cmbStatus.Location = new System.Drawing.Point(591, 140);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbStatus.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(472, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Beschreibung:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Lieferant:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Betrag Netto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Fälligkeitsdatum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Erstellungsdatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Rechnungsnummer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(197, -1);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 22);
            this.txtID.TabIndex = 36;
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.Location = new System.Drawing.Point(591, 109);
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.Size = new System.Drawing.Size(227, 22);
            this.txtBeschreibung.TabIndex = 33;
            // 
            // txtLieferant
            // 
            this.txtLieferant.Location = new System.Drawing.Point(189, 121);
            this.txtLieferant.Name = "txtLieferant";
            this.txtLieferant.Size = new System.Drawing.Size(227, 22);
            this.txtLieferant.TabIndex = 32;
            // 
            // cmdRechnungErstellen
            // 
            this.cmdRechnungErstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRechnungErstellen.Location = new System.Drawing.Point(887, 19);
            this.cmdRechnungErstellen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRechnungErstellen.Name = "cmdRechnungErstellen";
            this.cmdRechnungErstellen.Size = new System.Drawing.Size(172, 28);
            this.cmdRechnungErstellen.TabIndex = 26;
            this.cmdRechnungErstellen.Text = "Rechnung erstellen";
            this.cmdRechnungErstellen.UseVisualStyleBackColor = true;
            this.cmdRechnungErstellen.Click += new System.EventHandler(this.cmdRechnungErstellen_Click);
            // 
            // cmdRechnungAendern
            // 
            this.cmdRechnungAendern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRechnungAendern.Location = new System.Drawing.Point(887, 61);
            this.cmdRechnungAendern.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRechnungAendern.Name = "cmdRechnungAendern";
            this.cmdRechnungAendern.Size = new System.Drawing.Size(172, 28);
            this.cmdRechnungAendern.TabIndex = 24;
            this.cmdRechnungAendern.Text = "Rechnung ändern";
            this.cmdRechnungAendern.UseVisualStyleBackColor = true;
            this.cmdRechnungAendern.Click += new System.EventHandler(this.cmdRechnungAendern_Click);
            // 
            // cmdRechnungLoeschen
            // 
            this.cmdRechnungLoeschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRechnungLoeschen.Location = new System.Drawing.Point(887, 106);
            this.cmdRechnungLoeschen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRechnungLoeschen.Name = "cmdRechnungLoeschen";
            this.cmdRechnungLoeschen.Size = new System.Drawing.Size(172, 28);
            this.cmdRechnungLoeschen.TabIndex = 25;
            this.cmdRechnungLoeschen.Text = "Rechnung löschen";
            this.cmdRechnungLoeschen.UseVisualStyleBackColor = true;
            this.cmdRechnungLoeschen.Click += new System.EventHandler(this.cmdRechnungLoeschen_Click);
            // 
            // txtBetragN
            // 
            this.txtBetragN.Location = new System.Drawing.Point(591, 19);
            this.txtBetragN.Name = "txtBetragN";
            this.txtBetragN.Size = new System.Drawing.Size(227, 22);
            this.txtBetragN.TabIndex = 31;
            // 
            // txtRNr
            // 
            this.txtRNr.Location = new System.Drawing.Point(197, 27);
            this.txtRNr.Name = "txtRNr";
            this.txtRNr.Size = new System.Drawing.Size(227, 22);
            this.txtRNr.TabIndex = 27;
            // 
            // dgvBeschaffung
            // 
            this.dgvBeschaffung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeschaffung.Location = new System.Drawing.Point(0, 69);
            this.dgvBeschaffung.Name = "dgvBeschaffung";
            this.dgvBeschaffung.RowHeadersWidth = 51;
            this.dgvBeschaffung.RowTemplate.Height = 24;
            this.dgvBeschaffung.Size = new System.Drawing.Size(862, 338);
            this.dgvBeschaffung.TabIndex = 2;
            this.dgvBeschaffung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeschaffung_CellClick);
            // 
            // panFiltern
            // 
            this.panFiltern.Controls.Add(this.cmdBesFiltDel);
            this.panFiltern.Controls.Add(this.cmdBesFiltern);
            this.panFiltern.Controls.Add(this.cmdBesSuchen);
            this.panFiltern.Location = new System.Drawing.Point(868, 69);
            this.panFiltern.Name = "panFiltern";
            this.panFiltern.Size = new System.Drawing.Size(240, 338);
            this.panFiltern.TabIndex = 3;
            this.panFiltern.Visible = false;
            // 
            // cmdBesFiltDel
            // 
            this.cmdBesFiltDel.Location = new System.Drawing.Point(21, 114);
            this.cmdBesFiltDel.Name = "cmdBesFiltDel";
            this.cmdBesFiltDel.Size = new System.Drawing.Size(192, 23);
            this.cmdBesFiltDel.TabIndex = 2;
            this.cmdBesFiltDel.Text = "Filter entfernen";
            this.cmdBesFiltDel.UseVisualStyleBackColor = true;
            // 
            // cmdBesFiltern
            // 
            this.cmdBesFiltern.Location = new System.Drawing.Point(21, 74);
            this.cmdBesFiltern.Name = "cmdBesFiltern";
            this.cmdBesFiltern.Size = new System.Drawing.Size(192, 23);
            this.cmdBesFiltern.TabIndex = 1;
            this.cmdBesFiltern.Text = "Filter hinzufügen";
            this.cmdBesFiltern.UseVisualStyleBackColor = true;
            // 
            // cmdBesSuchen
            // 
            this.cmdBesSuchen.Location = new System.Drawing.Point(21, 31);
            this.cmdBesSuchen.Name = "cmdBesSuchen";
            this.cmdBesSuchen.Size = new System.Drawing.Size(192, 23);
            this.cmdBesSuchen.TabIndex = 0;
            this.cmdBesSuchen.Text = "Suchen";
            this.cmdBesSuchen.UseVisualStyleBackColor = true;
            // 
            // txtUst
            // 
            this.txtUst.Location = new System.Drawing.Point(591, 47);
            this.txtUst.Name = "txtUst";
            this.txtUst.Size = new System.Drawing.Size(227, 22);
            this.txtUst.TabIndex = 49;
            // 
            // txtBetragB
            // 
            this.txtBetragB.Location = new System.Drawing.Point(591, 76);
            this.txtBetragB.Name = "txtBetragB";
            this.txtBetragB.Size = new System.Drawing.Size(227, 22);
            this.txtBetragB.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Betrag Brutto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(472, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 52;
            this.label12.Text = "Steuer:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 54;
            this.label13.Text = "Menge:";
            // 
            // txtMenge
            // 
            this.txtMenge.Location = new System.Drawing.Point(189, 149);
            this.txtMenge.Name = "txtMenge";
            this.txtMenge.Size = new System.Drawing.Size(227, 22);
            this.txtMenge.TabIndex = 53;
            // 
            // Beschaffung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 587);
            this.Controls.Add(this.panFiltern);
            this.Controls.Add(this.dgvBeschaffung);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Beschaffung";
            this.Text = "Beschaffung";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeschaffung)).EndInit();
            this.panFiltern.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBeschaffung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panFiltern;
        private System.Windows.Forms.Button cmdBesFiltDel;
        private System.Windows.Forms.Button cmdBesFiltern;
        private System.Windows.Forms.Button cmdBesSuchen;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtBeschreibung;
        private System.Windows.Forms.TextBox txtLieferant;
        private System.Windows.Forms.Button cmdRechnungErstellen;
        private System.Windows.Forms.Button cmdRechnungAendern;
        private System.Windows.Forms.Button cmdRechnungLoeschen;
        private System.Windows.Forms.TextBox txtBetragN;
        private System.Windows.Forms.TextBox txtRNr;
        private System.Windows.Forms.DateTimePicker dtpFDat;
        private System.Windows.Forms.DateTimePicker dtpEDat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBetragB;
        private System.Windows.Forms.TextBox txtUst;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMenge;
    }
}