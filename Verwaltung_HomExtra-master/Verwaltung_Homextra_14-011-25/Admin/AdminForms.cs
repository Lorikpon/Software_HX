using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verwaltung_HomExtra
{
    public partial class AdminForms : Form
    {
        public AdminForms()
        {
            InitializeComponent();
            UserAnzeigen();
        }

        private void dgvVertrieb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserAnzeigen()
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = "Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root; Convert Zero Datetime=True";



            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM anmeldedaten", con);
           


            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvVertrieb.DataSource = table;
        }

        private void cmdRechnungErstellen_Click(object sender, EventArgs e)
        {
            int anzahl;
            MySqlConnection con = new MySqlConnection("Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root; Convert Zero Datetime=True");
            MySqlCommand cmd;




            try
            {
                con.Open();


                string query = @"INSERT INTO anmeldedaten 
                     (ID, username, password, role) 
                     VALUES (@ID, @username, @password, @role)";

                cmd = new MySqlCommand(query, con);

                // Parameter hinzufügen
                cmd.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@role", cmbRolle.SelectedItem?.ToString());
               


                anzahl = cmd.ExecuteNonQuery();

                if (anzahl > 0)
                {
                    MessageBox.Show("Datensatz erfolgreich hinzugefügt!");
                    UserAnzeigen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void cmdRechnungAendern_Click(object sender, EventArgs e)
        {
            try
            {

                using (MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=homextra_user;UID=root; Convert Zero Datetime=True"))
                {
                    con.Open();

                    string query = "UPDATE users SET username = @username, password = @password, role = @role, ID=@ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Parameter hinzufügen
                        cmd.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", cmbRolle.SelectedItem?.ToString());


                        int rowsAffected = cmd.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Daten erfolgreich aktualisiert.");
                            txtID.Text = "";
                            txtPasswort.Text = "";
                            txtUsername.Text = "";
                            cmbRolle.SelectedIndex = 0;
                            UserAnzeigen();

                        }
                        else
                        {
                            MessageBox.Show("Keine Datensätze aktualisiert. Bitte überprüfen Sie die ID.");
                            UserAnzeigen();
                        }
                    }
                    con.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void cmdRechnungLoeschen_Click(object sender, EventArgs e)
        {
            int anzahl;
            MySqlConnection con = new MySqlConnection("Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root; Convert Zero Datetime=True");
            MySqlCommand cmd;

            try
            {
                con.Open();
                cmd = new MySqlCommand("DELETE FROM users WHERE " + "ID = " + txtID.Text, con);

                anzahl = cmd.ExecuteNonQuery();

                if (anzahl > 0)
                {

                    MessageBox.Show("Datensatz gelöscht!");
                    txtID.Text = "";
                    txtPasswort.Text = "";
                    txtUsername.Text = "";
                    cmbRolle.SelectedIndex = 0;
                    UserAnzeigen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ein Problem ist aufgetreten. Bitte versichern Sie sich, dass Sie alles richtig eingegeben haben. Wenn dies der Fall ist, bitte wenden Sie sich an den Admin.", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            UserAnzeigen();
        }

        private void chbPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswort.PasswordChar = chbPass.Checked ? '\0' : '*';
        }
    }
}
