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
            this.chkPLZ = new System.Windows.Forms.CheckBox();
            this.cmdfiltern = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKreditoren)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.cmdfiltern);
            this.panel1.Controls.Add(this.chkPLZ);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cmdKredSuchen);
            this.panel1.Controls.Add(this.lblKreditoren);
            this.panel1.Controls.Add(this.cmdKredBack);
            this.panel1.Controls.Add(this.lblXKreditoren);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 122);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(366, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Suchen:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(444, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmdKredSuchen
            // 
            this.cmdKredSuchen.Location = new System.Drawing.Point(550, 10);
            this.cmdKredSuchen.Name = "cmdKredSuchen";
            this.cmdKredSuchen.Size = new System.Drawing.Size(95, 23);
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
            this.lblKreditoren.Location = new System.Drawing.Point(49, 29);
            this.lblKreditoren.Name = "lblKreditoren";
            this.lblKreditoren.Size = new System.Drawing.Size(156, 24);
            this.lblKreditoren.TabIndex = 3;
            this.lblKreditoren.Text = "Kreditorenansicht";
            this.lblKreditoren.Click += new System.EventHandler(this.lblKreditoren_Click);
            // 
            // cmdKredBack
            // 
            this.cmdKredBack.AutoSize = true;
            this.cmdKredBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdKredBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKredBack.Location = new System.Drawing.Point(3, 9);
            this.cmdKredBack.Name = "cmdKredBack";
            this.cmdKredBack.Size = new System.Drawing.Size(27, 18);
            this.cmdKredBack.TabIndex = 2;
            this.cmdKredBack.Text = "<--";
            this.cmdKredBack.Click += new System.EventHandler(this.cmdKredBack_Click);
            // 
            // lblXKreditoren
            // 
            this.lblXKreditoren.AutoSize = true;
            this.lblXKreditoren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblXKreditoren.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXKreditoren.Location = new System.Drawing.Point(770, 9);
            this.lblXKreditoren.Name = "lblXKreditoren";
            this.lblXKreditoren.Size = new System.Drawing.Size(18, 18);
            this.lblXKreditoren.TabIndex = 1;
            this.lblXKreditoren.Text = "X";
            this.lblXKreditoren.Click += new System.EventHandler(this.lblXKreditoren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(644, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kreditor löschen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdKreAnlegen
            // 
            this.cmdKreAnlegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdKreAnlegen.Location = new System.Drawing.Point(644, 20);
            this.cmdKreAnlegen.Name = "cmdKreAnlegen";
            this.cmdKreAnlegen.Size = new System.Drawing.Size(129, 23);
            this.cmdKreAnlegen.TabIndex = 3;
            this.cmdKreAnlegen.Text = "Kreditor anlegen";
            this.cmdKreAnlegen.UseVisualStyleBackColor = true;
            this.cmdKreAnlegen.Click += new System.EventHandler(this.cmdKreAnlegen_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(644, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
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
            this.dgvKreditoren.Location = new System.Drawing.Point(0, 122);
            this.dgvKreditoren.Name = "dgvKreditoren";
            this.dgvKreditoren.RowHeadersWidth = 51;
            this.dgvKreditoren.Size = new System.Drawing.Size(800, 191);
            this.dgvKreditoren.TabIndex = 2;
            this.dgvKreditoren.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKreditoren_CellClick);
            this.dgvKreditoren.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKreditoren_CellContentClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 42);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(120, 65);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(171, 20);
            this.txtAdresse.TabIndex = 5;
            this.txtAdresse.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPLZ
            // 
            this.txtPLZ.Location = new System.Drawing.Point(120, 88);
            this.txtPLZ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPLZ.Name = "txtPLZ";
            this.txtPLZ.Size = new System.Drawing.Size(171, 20);
            this.txtPLZ.TabIndex = 6;
            this.txtPLZ.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(120, 113);
            this.txtOrt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(171, 20);
            this.txtOrt.TabIndex = 7;
            this.txtOrt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(422, 20);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(171, 20);
            this.txtTelefon.TabIndex = 8;
            this.txtTelefon.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(422, 42);
            this.txtEMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(171, 20);
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
            this.panel2.Location = new System.Drawing.Point(0, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 137);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "BIC:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "IBAN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "UID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "E-Mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ort:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "PLZ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Adresse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 20);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 20);
            this.txtID.TabIndex = 13;
            // 
            // txtBIC
            // 
            this.txtBIC.Location = new System.Drawing.Point(422, 110);
            this.txtBIC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBIC.Name = "txtBIC";
            this.txtBIC.Size = new System.Drawing.Size(171, 20);
            this.txtBIC.TabIndex = 12;
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(422, 88);
            this.txtIBAN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(171, 20);
            this.txtIBAN.TabIndex = 11;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(422, 65);
            this.txtUID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(171, 20);
            this.txtUID.TabIndex = 10;
            // 
            // chkPLZ
            // 
            this.chkPLZ.AutoSize = true;
            this.chkPLZ.Location = new System.Drawing.Point(444, 52);
            this.chkPLZ.Name = "chkPLZ";
            this.chkPLZ.Size = new System.Drawing.Size(46, 17);
            this.chkPLZ.TabIndex = 8;
            this.chkPLZ.Text = "PLZ";
            this.chkPLZ.UseVisualStyleBackColor = true;
            // 
            // cmdfiltern
            // 
            this.cmdfiltern.Location = new System.Drawing.Point(550, 46);
            this.cmdfiltern.Name = "cmdfiltern";
            this.cmdfiltern.Size = new System.Drawing.Size(95, 23);
            this.cmdfiltern.TabIndex = 9;
            this.cmdfiltern.Text = "Filtern";
            this.cmdfiltern.UseVisualStyleBackColor = true;
            this.cmdfiltern.Click += new System.EventHandler(this.cmdfiltern_Click);
            // 
            // Kreditoren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKreditoren);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button cmdfiltern;
        private System.Windows.Forms.CheckBox chkPLZ;
    }
}