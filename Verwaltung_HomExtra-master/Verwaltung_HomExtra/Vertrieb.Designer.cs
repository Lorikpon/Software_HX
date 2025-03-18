namespace Verwaltung_HomExtra
{
    partial class Vertrieb
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panFiltern = new System.Windows.Forms.Panel();
            this.cmdBesFiltDel = new System.Windows.Forms.Button();
            this.cmdBesFiltern = new System.Windows.Forms.Button();
            this.cmdBesSuchen = new System.Windows.Forms.Button();
            this.dgvVertrieb = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMenge = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBetragB = new System.Windows.Forms.TextBox();
            this.txtUst = new System.Windows.Forms.TextBox();
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
            this.txtKunde = new System.Windows.Forms.TextBox();
            this.cmdRechnungErstellen = new System.Windows.Forms.Button();
            this.cmdRechnungAendern = new System.Windows.Forms.Button();
            this.cmdRechnungLoeschen = new System.Windows.Forms.Button();
            this.txtBetragN = new System.Windows.Forms.TextBox();
            this.txtRNr = new System.Windows.Forms.TextBox();
            this.panFiltern.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVertrieb)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(922, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bild";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vertrieb";
            // 
            // panFiltern
            // 
            this.panFiltern.Controls.Add(this.cmdBesFiltDel);
            this.panFiltern.Controls.Add(this.cmdBesFiltern);
            this.panFiltern.Controls.Add(this.cmdBesSuchen);
            this.panFiltern.Location = new System.Drawing.Point(868, 72);
            this.panFiltern.Name = "panFiltern";
            this.panFiltern.Size = new System.Drawing.Size(240, 292);
            this.panFiltern.TabIndex = 7;
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
            // dgvVertrieb
            // 
            this.dgvVertrieb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVertrieb.Location = new System.Drawing.Point(12, 72);
            this.dgvVertrieb.Name = "dgvVertrieb";
            this.dgvVertrieb.RowHeadersWidth = 51;
            this.dgvVertrieb.RowTemplate.Height = 24;
            this.dgvVertrieb.Size = new System.Drawing.Size(850, 292);
            this.dgvVertrieb.TabIndex = 6;
            this.dgvVertrieb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVertrieb_CellClick);
            this.dgvVertrieb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVertrieb_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 79;
            this.label13.Text = "Menge:";
            // 
            // txtMenge
            // 
            this.txtMenge.Location = new System.Drawing.Point(195, 520);
            this.txtMenge.Name = "txtMenge";
            this.txtMenge.Size = new System.Drawing.Size(227, 22);
            this.txtMenge.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(478, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = "Steuer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 76;
            this.label7.Text = "Betrag Brutto:";
            // 
            // txtBetragB
            // 
            this.txtBetragB.Location = new System.Drawing.Point(597, 447);
            this.txtBetragB.Name = "txtBetragB";
            this.txtBetragB.Size = new System.Drawing.Size(227, 22);
            this.txtBetragB.TabIndex = 75;
            // 
            // txtUst
            // 
            this.txtUst.Location = new System.Drawing.Point(597, 418);
            this.txtUst.Name = "txtUst";
            this.txtUst.Size = new System.Drawing.Size(227, 22);
            this.txtUst.TabIndex = 74;
            // 
            // dtpFDat
            // 
            this.dtpFDat.Location = new System.Drawing.Point(212, 453);
            this.dtpFDat.Name = "dtpFDat";
            this.dtpFDat.Size = new System.Drawing.Size(200, 22);
            this.dtpFDat.TabIndex = 73;
            // 
            // dtpEDat
            // 
            this.dtpEDat.Location = new System.Drawing.Point(212, 425);
            this.dtpEDat.Name = "dtpEDat";
            this.dtpEDat.Size = new System.Drawing.Size(200, 22);
            this.dtpEDat.TabIndex = 72;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ueberfaellig",
            "faellig",
            "gezahlt"});
            this.cmbStatus.Location = new System.Drawing.Point(597, 511);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbStatus.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(478, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 70;
            this.label11.Text = "Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(478, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 69;
            this.label10.Text = "Beschreibung:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "Kunde:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "Betrag Netto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "Fälligkeitsdatum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Erstellungsdatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Rechnungsnummer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(203, 370);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 22);
            this.txtID.TabIndex = 62;
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.Location = new System.Drawing.Point(597, 480);
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.Size = new System.Drawing.Size(227, 22);
            this.txtBeschreibung.TabIndex = 61;
            // 
            // txtKunde
            // 
            this.txtKunde.Location = new System.Drawing.Point(195, 492);
            this.txtKunde.Name = "txtKunde";
            this.txtKunde.Size = new System.Drawing.Size(227, 22);
            this.txtKunde.TabIndex = 60;
            // 
            // cmdRechnungErstellen
            // 
            this.cmdRechnungErstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRechnungErstellen.Location = new System.Drawing.Point(893, 390);
            this.cmdRechnungErstellen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRechnungErstellen.Name = "cmdRechnungErstellen";
            this.cmdRechnungErstellen.Size = new System.Drawing.Size(172, 28);
            this.cmdRechnungErstellen.TabIndex = 57;
            this.cmdRechnungErstellen.Text = "Rechnung erstellen";
            this.cmdRechnungErstellen.UseVisualStyleBackColor = true;
            this.cmdRechnungErstellen.Click += new System.EventHandler(this.cmdRechnungErstellen_Click);
            // 
            // cmdRechnungAendern
            // 
            this.cmdRechnungAendern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRechnungAendern.Location = new System.Drawing.Point(893, 432);
            this.cmdRechnungAendern.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRechnungAendern.Name = "cmdRechnungAendern";
            this.cmdRechnungAendern.Size = new System.Drawing.Size(172, 28);
            this.cmdRechnungAendern.TabIndex = 55;
            this.cmdRechnungAendern.Text = "Rechnung ändern";
            this.cmdRechnungAendern.UseVisualStyleBackColor = true;
            this.cmdRechnungAendern.Click += new System.EventHandler(this.cmdRechnungAendern_Click);
            // 
            // cmdRechnungLoeschen
            // 
            this.cmdRechnungLoeschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRechnungLoeschen.Location = new System.Drawing.Point(893, 477);
            this.cmdRechnungLoeschen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRechnungLoeschen.Name = "cmdRechnungLoeschen";
            this.cmdRechnungLoeschen.Size = new System.Drawing.Size(172, 28);
            this.cmdRechnungLoeschen.TabIndex = 56;
            this.cmdRechnungLoeschen.Text = "Rechnung löschen";
            this.cmdRechnungLoeschen.UseVisualStyleBackColor = true;
            this.cmdRechnungLoeschen.Click += new System.EventHandler(this.cmdRechnungLoeschen_Click);
            // 
            // txtBetragN
            // 
            this.txtBetragN.Location = new System.Drawing.Point(597, 390);
            this.txtBetragN.Name = "txtBetragN";
            this.txtBetragN.Size = new System.Drawing.Size(227, 22);
            this.txtBetragN.TabIndex = 59;
            // 
            // txtRNr
            // 
            this.txtRNr.Location = new System.Drawing.Point(203, 398);
            this.txtRNr.Name = "txtRNr";
            this.txtRNr.Size = new System.Drawing.Size(227, 22);
            this.txtRNr.TabIndex = 58;
            // 
            // Vertrieb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 551);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMenge);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBetragB);
            this.Controls.Add(this.txtUst);
            this.Controls.Add(this.dtpFDat);
            this.Controls.Add(this.dtpEDat);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtBeschreibung);
            this.Controls.Add(this.txtKunde);
            this.Controls.Add(this.cmdRechnungErstellen);
            this.Controls.Add(this.cmdRechnungAendern);
            this.Controls.Add(this.cmdRechnungLoeschen);
            this.Controls.Add(this.txtBetragN);
            this.Controls.Add(this.txtRNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panFiltern);
            this.Controls.Add(this.dgvVertrieb);
            this.Name = "Vertrieb";
            this.Text = "Vertrieb";
            this.panFiltern.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVertrieb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panFiltern;
        private System.Windows.Forms.Button cmdBesFiltDel;
        private System.Windows.Forms.Button cmdBesFiltern;
        private System.Windows.Forms.Button cmdBesSuchen;
        private System.Windows.Forms.DataGridView dgvVertrieb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMenge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBetragB;
        private System.Windows.Forms.TextBox txtUst;
        private System.Windows.Forms.DateTimePicker dtpFDat;
        private System.Windows.Forms.DateTimePicker dtpEDat;
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
        private System.Windows.Forms.TextBox txtKunde;
        private System.Windows.Forms.Button cmdRechnungErstellen;
        private System.Windows.Forms.Button cmdRechnungAendern;
        private System.Windows.Forms.Button cmdRechnungLoeschen;
        private System.Windows.Forms.TextBox txtBetragN;
        private System.Windows.Forms.TextBox txtRNr;
    }
}