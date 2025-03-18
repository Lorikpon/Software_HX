using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Verwaltung_HomExtra
{
    public partial class Kreditoren : Form
    {
        public Kreditoren()
        {
            InitializeComponent();
           // KreditorenAnzeigen();
        }

       

        private void cmdKreAnlegen_Click(object sender, EventArgs e)
        {
            int anzahl;
            MySqlConnection con = new MySqlConnection("Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root");
            MySqlCommand cmd;




            try
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO kreditoren (ID, Name, Adresse, PLZ, Ort, Telefon, Email, UID, IBAN, BIC) " +
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ein Problem ist aufgetreten. Bitte versichern Sie sich, dass Sie alles richtig eingegeben haben. Wenn dies der Fall ist, bitte wenden Sie sich an den Admin.", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
          //  Kreditoren kreditoren = new Kreditoren();
          //  kreditoren.Show();
          //  this.Hide();
            KreditorenAnzeigen();


        }

        private void cmdKreAnzeigen_Click(object sender, EventArgs e)
        {
            KreditorenAnzeigen();
        }

        private void KreditorenAnzeigen()
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            
            con.ConnectionString = "Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root";

            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM kreditoren", con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvKreditoren.DataSource = table;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                using (MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=homextra_user;UID=root"))
                {
                    con.Open();

                    string query = "UPDATE kreditoren SET Name = @name, Adresse = @adresse, PLZ = @plz, Ort = @ort, Telefon = @telefon, Email = @email, UID = @uid, IBAN = @iban, BIC = @bic WHERE ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text);
                        cmd.Parameters.AddWithValue("@plz", txtPLZ.Text);
                        cmd.Parameters.AddWithValue("@ort", txtOrt.Text);
                        cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                        cmd.Parameters.AddWithValue("@email", txtEMail.Text);
                        cmd.Parameters.AddWithValue("@uid", txtUID.Text);
                        cmd.Parameters.AddWithValue("@iban", txtIBAN.Text);
                        cmd.Parameters.AddWithValue("@bic", txtBIC.Text);
                        cmd.Parameters.AddWithValue("@id", txtID.Text); 

                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        
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
                        }
                        else
                        {
                            MessageBox.Show("Keine Datensätze aktualisiert. Bitte überprüfen Sie die ID.");
                        }
                    }
                    con.Close();
                    //Kreditoren kreditoren = new Kreditoren();
                    //kreditoren.Show();
                    //this.Hide();
                    KreditorenAnzeigen();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int anzahl;
            MySqlConnection con = new MySqlConnection("Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root");
            MySqlCommand cmd;

            try
            {
                con.Open();
                cmd = new MySqlCommand("DELETE FROM kreditoren WHERE " + "ID = " + txtID.Text, con);

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ein Problem ist aufgetreten. Bitte versichern Sie sich, dass Sie alles richtig eingegeben haben. Wenn dies der Fall ist, bitte wenden Sie sich an den Admin.", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            KreditorenAnzeigen();
        }

        private void lblXKreditoren_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdKredBack_Click(object sender, EventArgs e)
        {
            MAAnsicht mAAnsicht = new MAAnsicht();
            mAAnsicht.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdKredSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=homextra_user;UID=root"))
                {
                    con.Open();

              
                    string query = "SELECT * FROM kreditoren WHERE Name LIKE @name";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + textBox1.Text + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvKreditoren.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvKreditoren_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dgvKreditoren.Rows[e.RowIndex];
                txtName.Text = row.Cells[1].Value.ToString();
                txtAdresse.Text=row.Cells[2].Value.ToString();
                txtPLZ.Text=row.Cells[3].Value.ToString();
                txtOrt.Text=row.Cells[4].Value.ToString();
                txtTelefon.Text=row.Cells[5].Value.ToString();
                txtEMail.Text=row.Cells[6].Value.ToString();
                txtUID.Text=row.Cells[7].Value.ToString();
                txtIBAN.Text=row.Cells[8].Value.ToString();
                txtBIC.Text=row.Cells[9].Value.ToString();
                txtID.Text=row.Cells[0].Value.ToString();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblKreditoren_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvKreditoren_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
