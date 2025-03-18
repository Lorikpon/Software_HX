namespace Verwaltung_HomExtra
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBenutzernameAnmelden = new System.Windows.Forms.TextBox();
            this.txtPasswortAnmelden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdAnmelden = new System.Windows.Forms.Button();
            this.chkPassAnzeigen = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 554);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.Location = new System.Drawing.Point(53, 426);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Benutzer registrieren";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(53, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Verwaltungssytem";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(760, 11);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(24, 25);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anmelden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Benutzername:";
            // 
            // txtBenutzernameAnmelden
            // 
            this.txtBenutzernameAnmelden.Location = new System.Drawing.Point(359, 224);
            this.txtBenutzernameAnmelden.Margin = new System.Windows.Forms.Padding(4);
            this.txtBenutzernameAnmelden.Name = "txtBenutzernameAnmelden";
            this.txtBenutzernameAnmelden.Size = new System.Drawing.Size(359, 22);
            this.txtBenutzernameAnmelden.TabIndex = 4;
            // 
            // txtPasswortAnmelden
            // 
            this.txtPasswortAnmelden.Location = new System.Drawing.Point(359, 319);
            this.txtPasswortAnmelden.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswortAnmelden.Name = "txtPasswortAnmelden";
            this.txtPasswortAnmelden.PasswordChar = '*';
            this.txtPasswortAnmelden.Size = new System.Drawing.Size(359, 22);
            this.txtPasswortAnmelden.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Passwort:";
            // 
            // cmdAnmelden
            // 
            this.cmdAnmelden.BackColor = System.Drawing.Color.Red;
            this.cmdAnmelden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAnmelden.FlatAppearance.BorderSize = 0;
            this.cmdAnmelden.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaShell;
            this.cmdAnmelden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.cmdAnmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAnmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnmelden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAnmelden.Location = new System.Drawing.Point(359, 426);
            this.cmdAnmelden.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAnmelden.Name = "cmdAnmelden";
            this.cmdAnmelden.Size = new System.Drawing.Size(165, 63);
            this.cmdAnmelden.TabIndex = 7;
            this.cmdAnmelden.Text = "Anmelden";
            this.cmdAnmelden.UseVisualStyleBackColor = false;
            this.cmdAnmelden.Click += new System.EventHandler(this.cmdAnmelden_Click);
            // 
            // chkPassAnzeigen
            // 
            this.chkPassAnzeigen.AutoSize = true;
            this.chkPassAnzeigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPassAnzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPassAnzeigen.Location = new System.Drawing.Point(545, 351);
            this.chkPassAnzeigen.Margin = new System.Windows.Forms.Padding(4);
            this.chkPassAnzeigen.Name = "chkPassAnzeigen";
            this.chkPassAnzeigen.Size = new System.Drawing.Size(156, 22);
            this.chkPassAnzeigen.TabIndex = 8;
            this.chkPassAnzeigen.Text = "Passwort anzeigen";
            this.chkPassAnzeigen.UseVisualStyleBackColor = true;
            this.chkPassAnzeigen.CheckedChanged += new System.EventHandler(this.chkPassAnzeigen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.chkPassAnzeigen);
            this.Controls.Add(this.cmdAnmelden);
            this.Controls.Add(this.txtPasswortAnmelden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBenutzernameAnmelden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBenutzernameAnmelden;
        private System.Windows.Forms.TextBox txtPasswortAnmelden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPassAnzeigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdAnmelden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

