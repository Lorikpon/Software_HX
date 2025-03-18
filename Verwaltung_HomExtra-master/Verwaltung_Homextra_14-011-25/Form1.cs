using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Verwaltung_HomExtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bitte wenden Sie sich an den Admin, wenn ein Benutzer für Sie angelegt werden soll.", "Benutzer anlegen:", MessageBoxButtons.OK); //sinnvoll?
        }

        private void chkPassAnzeigen_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswortAnmelden.PasswordChar = chkPassAnzeigen.Checked ? '\0' : '*';  //BEDEUTUNG SUCHEN!!!
        }

        private void cmdAnmelden_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            
            MySqlDataReader reader;

            con.ConnectionString = "Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root";

            if (txtBenutzernameAnmelden.Text == ""
                || txtPasswortAnmelden.Text == "")
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {

                    try
                    {
                        con.Open();

                        string Daten = "SELECT * FROM anmeldedaten WHERE Benutzername =@Benutzername " + "AND Passwort = @Passwort";

                        using (MySqlCommand cmd = new MySqlCommand(Daten, con))
                        {
                            cmd.Parameters.AddWithValue("@Benutzername",txtBenutzernameAnmelden.Text.Trim());
                            cmd.Parameters.AddWithValue("@Passwort", txtPasswortAnmelden.Text.Trim());

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Willkommen!","Anmeldung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MAAnsicht mAAnsicht = new MAAnsicht();
                                mAAnsicht.Show();
                                this.Hide();
                                
                            }
                            else
                            {
                                MessageBox.Show("Benutzername oder Passwort ist falsch", "Fehler:", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler: " + ex, "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MAAnsicht ma1 = new MAAnsicht();
            ma1.Show();
            this.Hide();
        }
    }
}
