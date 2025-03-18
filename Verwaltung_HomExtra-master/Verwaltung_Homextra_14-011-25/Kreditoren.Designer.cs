namespace Verwaltung_HomExtra
{
    partial class Kreditoren
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
            this.cmdKreAnzeigen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdKredSuchen = new System.Windows.Forms.Button();
            this.lblKreditoren = new System.Windows.Forms.Label();
            this.cmdKredBack = new System.Windows.Forms.Label();
            this.lblXKreditoren = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdKreAnlegen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvKreditoren = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPLZ = new System.Windows.Forms.TextBox();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtBIC = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKreditoren)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdKreAnzeigen);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cmdKredSuchen);
            this.panel1.Controls.Add(this.lblKreditoren);
            this.panel1.Controls.Add(this.cmdKredBack);
            this.panel1.Controls.Add(this.lblXKreditoren);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 150);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(488, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Suchen:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmdKreAnzeigen
            // 
            this.cmdKreAnzeigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdKreAnzeigen.Location = new System.Drawing.Point(70, 87);
            this.cmdKreAnzeigen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdKreAnzeigen.Name = "cmdKreAnzeigen";
            this.cmdKreAnzeigen.Size = new System.Drawing.Size(172, 28);
            this.cmdKreAnzeigen.TabIndex = 4;
            this.cmdKreAnzeigen.Text = "Kreditoren anzeigen";
            this.cmdKreAnzeigen.UseVisualStyleBackColor = true;
            this.cmdKreAnzeigen.Click += new System.EventHandler(this.cmdKreAnzeigen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(592, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmdKredSuchen
            // 
            this.cmdKredSuchen.Location = new System.Drawing.Point(733, 12);
            this.cmdKredSuchen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdKredSuchen.Name = "cmdKredSuchen";
            this.cmdKredSuchen.Size = new System.Drawing.Size(127, 28);
            this.cmdKredSuchen.TabIndex = 4;
            this.cmdKredSuchen.Text = "Suchen";
            this.cmdKredSuchen.UseVisualStyleBackColor = true;
            this.cmdKredSuchen.Click += new System.EventHandler(this.cmdKredSuchen_Click);
            // 
            // lblKreditoren
            // 
            this.lblKreditoren.AutoSize = true;
            this.lblKreditoren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKreditoren.ForeColor = System.Drawing.Color.White;
            this.lblKreditoren.Location = new System.Drawing.Point(65, 36);
            this.lblKreditoren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKreditoren.Name = "lblKreditoren";
            this.lblKreditoren.Size = new System.Drawing.Size(201, 29);
            this.lblKreditoren.TabIndex = 3;
            this.lblKreditoren.Text = "Kreditorenansicht";
            this.lblKreditoren.Click += new System.EventHandler(this.lblKreditoren_Click);
            // 
            // cmdKredBack
            // 
            this.cmdKredBack.AutoSize = true;
            this.cmdKredBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdKredBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKredBack.Location = new System.Drawing.Point(4, 11);
            this.cmdKredBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmdKredBack.Name = "cmdKredBack";
            this.cmdKredBack.Size = new System.Drawing.Size(33, 24);
            this.cmdKredBack.TabIndex = 2;
            this.cmdKredBack.Text = "<--";
            this.cmdKredBack.Click += new System.EventHandler(this.cmdKredBack_Click);
            // 
            // lblXKreditoren
            // 
            this.lblXKreditoren.AutoSize = true;
            this.lblXKreditoren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblXKreditoren.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXKreditoren.Location = new System.Drawing.Point(1027, 11);
            this.lblXKreditoren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXKreditoren.Name = "lblXKreditoren";
            this.lblXKreditoren.Size = new System.Drawing.Size(24, 24);
            this.lblXKreditoren.TabIndex = 1;
            this.lblXKreditoren.Text = "X";
            this.lblXKreditoren.Click += new System.EventHandler(this.lblXKreditoren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(858, 111);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kreditor löschen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdKreAnlegen
            // 
            this.cmdKreAnlegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdKreAnlegen.Location = new System.Drawing.Point(858, 24);
            this.cmdKreAnlegen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdKreAnlegen.Name = "cmdKreAnlegen";
            this.cmdKreAnlegen.Size = new System.Drawing.Size(172, 28);
            this.cmdKreAnlegen.TabIndex = 3;
            this.cmdKreAnlegen.Text = "Kreditor anlegen";
            this.cmdKreAnlegen.UseVisualStyleBackColor = true;
            this.cmdKreAnlegen.Click += new System.EventHandler(this.cmdKreAnlegen_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(858, 66);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kreditor ändern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvKreditoren
            // 
            this.dgvKreditoren.BackgroundColor = System.Drawing.Color.White;
            this.dgvKreditoren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKreditoren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKreditoren.Location = new System.Drawing.Point(0, 150);
            this.dgvKreditoren.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKreditoren.Name = "dgvKreditoren";
            this.dgvKreditoren.RowHeadersWidth = 51;
            this.dgvKreditoren.Size = new System.Drawing.Size(1067, 235);
            this.dgvKreditoren.TabIndex = 2;
            this.dgvKreditoren.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKreditoren_CellClick);
            this.dgvKreditoren.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKreditoren_CellContentClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 22);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(160, 80);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(227, 22);
            this.txtAdresse.TabIndex = 5;
            this.txtAdresse.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPLZ
            // 
            this.txtPLZ.Location = new System.Drawing.Point(160, 108);
            this.txtPLZ.Name = "txtPLZ";
            this.txtPLZ.Size = new System.Drawing.Size(227, 22);
            this.txtPLZ.TabIndex = 6;
            this.txtPLZ.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(160, 139);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(227, 22);
            this.txtOrt.TabIndex = 7;
            this.txtOrt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(562, 24);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(227, 22);
            this.txtTelefon.TabIndex = 8;
            this.txtTelefon.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(562, 52);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(227, 22);
            this.txtEMail.TabIndex = 9;
            this.txtEMail.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
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
            this.panel2.Controls.Add(this.cmdKreAnlegen);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.txtTelefon);
            this.panel2.Controls.Add(this.txtOrt);
            this.panel2.Controls.Add(this.txtPLZ);
            this.panel2.Controls.Add(this.txtAdresse);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 385);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 169);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(562, 80);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(227, 22);
            this.txtUID.TabIndex = 10;
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(562, 108);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(227, 22);
            this.txtIBAN.TabIndex = 11;
            // 
            // txtBIC
            // 
            this.txtBIC.Location = new System.Drawing.Point(562, 135);
            this.txtBIC.Name = "txtBIC";
            this.txtBIC.Size = new System.Drawing.Size(227, 22);
            this.txtBIC.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(160, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 22);
            this.txtID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Adresse:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "PLZ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ort:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "E-Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "UID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "IBAN:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(443, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "BIC:";
            // 
            // Kreditoren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvKreditoren);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kreditoren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreditoren";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKreditoren)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdKreAnlegen;
        private System.Windows.Forms.Button cmdKreAnzeigen;
        private System.Windows.Forms.Label cmdKredBack;
        private System.Windows.Forms.Label lblXKreditoren;
        private System.Windows.Forms.DataGridView dgvKreditoren;
        private System.Windows.Forms.Label lblKreditoren;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdKredSuchen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPLZ;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBIC;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.TextBox txtID;
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
    }
}