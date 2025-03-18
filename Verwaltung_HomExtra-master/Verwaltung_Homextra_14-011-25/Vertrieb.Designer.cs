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
            this.dgvBeschaffung = new System.Windows.Forms.DataGridView();
            this.panFiltern.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeschaffung)).BeginInit();
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
            this.panFiltern.Size = new System.Drawing.Size(240, 338);
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
            // dgvBeschaffung
            // 
            this.dgvBeschaffung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeschaffung.Location = new System.Drawing.Point(12, 72);
            this.dgvBeschaffung.Name = "dgvBeschaffung";
            this.dgvBeschaffung.RowHeadersWidth = 51;
            this.dgvBeschaffung.RowTemplate.Height = 24;
            this.dgvBeschaffung.Size = new System.Drawing.Size(850, 338);
            this.dgvBeschaffung.TabIndex = 6;
            // 
            // Vertrieb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panFiltern);
            this.Controls.Add(this.dgvBeschaffung);
            this.Name = "Vertrieb";
            this.Text = "Vertrieb";
            this.panFiltern.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeschaffung)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvBeschaffung;
    }
}