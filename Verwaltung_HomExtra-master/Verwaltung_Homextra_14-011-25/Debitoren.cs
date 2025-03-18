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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Verwaltung_HomExtra
{
    public partial class Debitoren : Form
    {
        public Debitoren()
        {
            InitializeComponent();
            DebitorenAnzeigen();
        }

        private void DebX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DebBack_Click(object sender, EventArgs e)
        {
            MAAnsicht mAAnsicht = new MAAnsicht();
            mAAnsicht.Show();
            this.Hide();
        }

        private void DebitorenAnzeigen()
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = "Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root";

            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM debitoren", con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvDebitoren.DataSource = table;
        }

        private void cmdDebAnlegen_Click(object sender, EventArgs e)
        {
            int anzahl;
            MySqlConnection con = new MySqlConnection("Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root");
            MySqlCommand cmd;




            try
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO debitoren (ID, Name, Adresse, PLZ, Ort, Telefon, Email, UID, IBAN, BIC) " +
                    "VALUES ('" + txtID.Text + "', '" + txtName.Text + "', '" + txtAdresse.Text + "', '" + txtPLZ.Text + "', '" + txtOrt.Text + "', '" +
                    txtTelefon.Text + "', '" + txtEMail.Text + "', '" + txtUID.Text + "', '" + txtIBAN.Text + "', '" + txtBIC.Text + "')", con);

                anzahl = cmd.ExecuteNonQuery();

                if (anzahl > 0)
                {
                    MessageBox.Show("Datensatz hinzugefügt!");
                    txtID.Text = "";
                    txtName.Text = "";
                    txtAdresse.Text = "";
                    txtPLZ.Text = "";
                    txtOrt.Text = "";
                    txtTelefon.Text = "";
                    txtEMail.Text = "";
                    txtBIC.Text = "";
                    txtIBAN.Text = "";
                    txtUID.Text = "";
                    DebitorenAnzeigen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ein Problem ist aufgetreten. Bitte versichern Sie sich, dass Sie alles richtig eingegeben haben. Wenn dies der Fall ist, bitte wenden Sie sich an den Admin.", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
            // Debitoren debitoren = new Debitoren();
            // debitoren.Show();
            // this.Hide();
            DebitorenAnzeigen();
            
        }

        private void cmdDebAendern_Click(object sender, EventArgs e)
        {
            try
            {

                using (MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=homextra_user;UID=root"))
                {
                    con.Open();

                    string query = "UPDATE debitoren SET Name = @name, Adresse = @adresse, PLZ = @plz, Ort = @ort, Telefon = @telefon, Email = @email, UID = @uid, IBAN = @iban, BIC = @bic WHERE ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Parameter hinzufügen
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text);
                        cmd.Parameters.AddWithValue("@plz", txtPLZ.Text);
                        cmd.Parameters.AddWithValue("@ort", txtOrt.Text);
                        cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                        cmd.Parameters.AddWithValue("@email", txtEMail.Text);
                        cmd.Parameters.AddWithValue("@uid", txtUID.Text);
                        cmd.Parameters.AddWithValue("@iban", txtIBAN.Text);
                        cmd.Parameters.AddWithValue("@bic", txtBIC.Text);
                        cmd.Parameters.AddWithValue("@id", txtID.Text); // Assuming ID is a string; adjust as necessary

                        // Ausführung des Update-Befehls
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Optional: Rückmeldung an den Benutzer
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Daten erfolgreich aktualisiert.");
                            txtID.Text = "";
                            txtName.Text = "";
                            txtAdresse.Text = "";
                            txtPLZ.Text = "";
                            txtOrt.Text = "";
                            txtTelefon.Text = "";
                            txtEMail.Text = "";
                            txtBIC.Text = "";
                            txtIBAN.Text = "";
                            txtUID.Text = "";
                            DebitorenAnzeigen();
                        }
                        else
                        {
                            MessageBox.Show("Keine Datensätze aktualisiert. Bitte überprüfen Sie die ID.");
                        }
                    }
                    con.Close();
                    Debitoren debitoren = new Debitoren();
                    debitoren.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void cmdDebLoeschen_Click(object sender, EventArgs e)
        {
            int anzahl;
            MySqlConnection con = new MySqlConnection("Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root");
            MySqlCommand cmd;

            try
            {
                con.Open();
                cmd = new MySqlCommand("DELETE FROM debitoren WHERE " + "ID = " + txtID.Text, con);

                anzahl = cmd.ExecuteNonQuery();

                if (anzahl > 0)
                {

                    MessageBox.Show("Datensatz gelöscht!");
                    txtID.Text = "";
                    txtName.Text = "";
                    txtAdresse.Text = "";
                    txtPLZ.Text = "";
                    txtOrt.Text = "";
                    txtTelefon.Text = "";
                    txtEMail.Text = "";
                    txtBIC.Text = "";
                    txtIBAN.Text = "";
                    txtUID.Text = "";
                    DebitorenAnzeigen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ein Problem ist aufgetreten. Bitte versichern Sie sich, dass Sie alles richtig eingegeben haben. Wenn dies der Fall ist, bitte wenden Sie sich an den Admin.", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cmdDebAnzeigen_Click(object sender, EventArgs e)
        {
            DebitorenAnzeigen();
        }

        

        private void cmdDebSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=homextra_user;UID=root"))
                {
                    con.Open();

                    // Verwende Parameter, um SQL-Injection zu vermeiden
                    string query = "SELECT * FROM debitoren WHERE Name LIKE @name";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + txtSuchDeb.Text + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvDebitoren.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDebitoren_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvDebitoren.Rows[e.RowIndex];
                txtName.Text = row.Cells[1].Value.ToString();
                txtAdresse.Text = row.Cells[2].Value.ToString();
                txtPLZ.Text = row.Cells[3].Value.ToString();
                txtOrt.Text = row.Cells[4].Value.ToString();
                txtTelefon.Text = row.Cells[5].Value.ToString();
                txtEMail.Text = row.Cells[6].Value.ToString();
                txtUID.Text = row.Cells[7].Value.ToString();
                txtIBAN.Text = row.Cells[8].Value.ToString();
                txtBIC.Text = row.Cells[9].Value.ToString();
                txtID.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}
