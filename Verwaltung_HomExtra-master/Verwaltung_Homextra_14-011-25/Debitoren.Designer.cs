namespace Verwaltung_HomExtra
{
    partial class Debitoren
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
            this.txtSuchDeb = new System.Windows.Forms.TextBox();
            this.cmdDebSuchen = new System.Windows.Forms.Button();
            this.DebX = new System.Windows.Forms.Label();
            this.DebBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdDebLoeschen = new System.Windows.Forms.Button();
            this.cmdDebAendern = new System.Windows.Forms.Button();
            this.cmdDebAnlegen = new System.Windows.Forms.Button();
            this.cmdDebAnzeigen = new System.Windows.Forms.Button();
            this.dgvDebitoren = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtBIC = new System.Windows.Forms.TextBox();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.txtPLZ = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitoren)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSuchDeb);
            this.panel1.Controls.Add(this.cmdDebSuchen);
            this.panel1.Controls.Add(this.cmdDebAnzeigen);
            this.panel1.Controls.Add(this.DebX);
            this.panel1.Controls.Add(this.DebBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 94);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(497, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Suchen:";
            // 
            // txtSuchDeb
            // 
            this.txtSuchDeb.Location = new System.Drawing.Point(599, 32);
            this.txtSuchDeb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSuchDeb.Name = "txtSuchDeb";
            this.txtSuchDeb.Size = new System.Drawing.Size(132, 22);
            this.txtSuchDeb.TabIndex = 9;
            // 
            // cmdDebSuchen
            // 
            this.cmdDebSuchen.Location = new System.Drawing.Point(740, 30);
            this.cmdDebSuchen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDebSuchen.Name = "cmdDebSuchen";
            this.cmdDebSuchen.Size = new System.Drawing.Size(127, 28);
            this.cmdDebSuchen.TabIndex = 8;
            this.cmdDebSuchen.Text = "Suchen";
            this.cmdDebSuchen.UseVisualStyleBackColor = true;
            this.cmdDebSuchen.Click += new System.EventHandler(this.cmdDebSuchen_Click);
            // 
            // DebX
            // 
            this.DebX.AutoSize = true;
            this.DebX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DebX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebX.Location = new System.Drawing.Point(1027, 11);
            this.DebX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DebX.Name = "DebX";
            this.DebX.Size = new System.Drawing.Size(24, 24);
            this.DebX.TabIndex = 2;
            this.DebX.Text = "X";
            this.DebX.Click += new System.EventHandler(this.DebX_Click);
            // 
            // DebBack
            // 
            this.DebBack.AutoSize = true;
            this.DebBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DebBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebBack.Location = new System.Drawing.Point(16, 11);
            this.DebBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DebBack.Name = "DebBack";
            this.DebBack.Size = new System.Drawing.Size(33, 24);
            this.DebBack.TabIndex = 1;
            this.DebBack.Text = "<--";
            this.DebBack.Click += new System.EventHandler(this.DebBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debitorenansicht";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.txtBIC);
            this.panel2.Controls.Add(this.txtIBAN);
            this.panel2.Controls.Add(this.txtUID);
            this.panel2.Controls.Add(this.txtEMail);
            this.panel2.Controls.Add(this.txtTelefon);
            this.panel2.Controls.Add(this.txtOrt);
            this.panel2.Controls.Add(this.txtPLZ);
            this.panel2.Controls.Add(this.txtAdresse);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.cmdDebLoeschen);
            this.panel2.Controls.Add(this.cmdDebAendern);
            this.panel2.Controls.Add(this.cmdDebAnlegen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 424);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 158);
            this.panel2.TabIndex = 1;
            // 
            // cmdDebLoeschen
            // 
            this.cmdDebLoeschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDebLoeschen.Location = new System.Drawing.Point(858, 101);
            this.cmdDebLoeschen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDebLoeschen.Name = "cmdDebLoeschen";
            this.cmdDebLoeschen.Size = new System.Drawing.Size(153, 28);
            this.cmdDebLoeschen.TabIndex = 3;
            this.cmdDebLoeschen.Text = "Debitoren löschen";
            this.cmdDebLoeschen.UseVisualStyleBackColor = true;
            this.cmdDebLoeschen.Click += new System.EventHandler(this.cmdDebLoeschen_Click);
            // 
            // cmdDebAendern
            // 
            this.cmdDebAendern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDebAendern.Location = new System.Drawing.Point(858, 65);
            this.cmdDebAendern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDebAendern.Name = "cmdDebAendern";
            this.cmdDebAendern.Size = new System.Drawing.Size(153, 28);
            this.cmdDebAendern.TabIndex = 2;
            this.cmdDebAendern.Text = "Debitoren ändern";
            this.cmdDebAendern.UseVisualStyleBackColor = true;
            this.cmdDebAendern.Click += new System.EventHandler(this.cmdDebAendern_Click);
            // 
            // cmdDebAnlegen
            // 
            this.cmdDebAnlegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDebAnlegen.Location = new System.Drawing.Point(858, 29);
            this.cmdDebAnlegen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDebAnlegen.Name = "cmdDebAnlegen";
            this.cmdDebAnlegen.Size = new System.Drawing.Size(153, 28);
            this.cmdDebAnlegen.TabIndex = 1;
            this.cmdDebAnlegen.Text = "Debitoren anlegen";
            this.cmdDebAnlegen.UseVisualStyleBackColor = true;
            this.cmdDebAnlegen.Click += new System.EventHandler(this.cmdDebAnlegen_Click);
            // 
            // cmdDebAnzeigen
            // 
            this.cmdDebAnzeigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDebAnzeigen.Location = new System.Drawing.Point(319, 58);
            this.cmdDebAnzeigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDebAnzeigen.Name = "cmdDebAnzeigen";
            this.cmdDebAnzeigen.Size = new System.Drawing.Size(151, 28);
            this.cmdDebAnzeigen.TabIndex = 0;
            this.cmdDebAnzeigen.Text = "Debitoren anzeigen";
            this.cmdDebAnzeigen.UseVisualStyleBackColor = true;
            this.cmdDebAnzeigen.Click += new System.EventHandler(this.cmdDebAnzeigen_Click);
            // 
            // dgvDebitoren
            // 
            this.dgvDebitoren.BackgroundColor = System.Drawing.Color.White;
            this.dgvDebitoren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebitoren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebitoren.Location = new System.Drawing.Point(0, 94);
            this.dgvDebitoren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDebitoren.Name = "dgvDebitoren";
            this.dgvDebitoren.RowHeadersWidth = 51;
            this.dgvDebitoren.Size = new System.Drawing.Size(1067, 330);
            this.dgvDebitoren.TabIndex = 3;
            this.dgvDebitoren.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDebitoren_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(464, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "BIC:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "IBAN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "UID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "E-Mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ort:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "PLZ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Adresse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(181, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 22);
            this.txtID.TabIndex = 33;
            // 
            // txtBIC
            // 
            this.txtBIC.Location = new System.Drawing.Point(583, 118);
            this.txtBIC.Name = "txtBIC";
            this.txtBIC.Size = new System.Drawing.Size(227, 22);
            this.txtBIC.TabIndex = 32;
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(583, 91);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(227, 22);
            this.txtIBAN.TabIndex = 31;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(583, 63);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(227, 22);
            this.txtUID.TabIndex = 30;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(583, 35);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(227, 22);
            this.txtEMail.TabIndex = 29;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(583, 7);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(227, 22);
            this.txtTelefon.TabIndex = 28;
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(181, 122);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(227, 22);
            this.txtOrt.TabIndex = 27;
            // 
            // txtPLZ
            // 
            this.txtPLZ.Location = new System.Drawing.Point(181, 91);
            this.txtPLZ.Name = "txtPLZ";
            this.txtPLZ.Size = new System.Drawing.Size(227, 22);
            this.txtPLZ.TabIndex = 26;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(181, 63);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(227, 22);
            this.txtAdresse.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 22);
            this.txtName.TabIndex = 24;
            // 
            // Debitoren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 582);
            this.Controls.Add(this.dgvDebitoren);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Debitoren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debitoren";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitoren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdDebLoeschen;
        private System.Windows.Forms.Button cmdDebAendern;
        private System.Windows.Forms.Button cmdDebAnlegen;
        private System.Windows.Forms.Button cmdDebAnzeigen;
        private System.Windows.Forms.Label DebX;
        private System.Windows.Forms.Label DebBack;
        private System.Windows.Forms.DataGridView dgvDebitoren;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuchDeb;
        private System.Windows.Forms.Button cmdDebSuchen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtBIC;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.TextBox txtPLZ;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtName;
    }
}