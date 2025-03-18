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
using System.Xml.Linq;

namespace Verwaltung_HomExtra
{
    public partial class Beschaffung : Form
    {
        public Beschaffung()
        {
            InitializeComponent();
            RechnungenAnzeigen();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (panFiltern.Visible == true)
            {
                panFiltern.Visible = false;
            }
            else
            {
                panFiltern.Visible = true;
            }
        }

        private void RechnungenAnzeigen()
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = "Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root; Convert Zero Datetime=True";



            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM eingangsrechnungen", con);
            cmd.Parameters.AddWithValue("@Erstellungsdatum", dtpEDat.Value.ToString("dd-MM-yyyy"));
            cmd.Parameters.AddWithValue("@Faelligkeitsdatum", dtpFDat.Value.ToString("dd-MM-yyyy"));


            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvBeschaffung.DataSource = table;
        }

        private void cmdRechnungErstellen_Click(object sender, EventArgs e)
        {
            int anzahl;
            MySqlConnection con = new MySqlConnection("Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root; Convert Zero Datetime=True");
            MySqlCommand cmd;




            try
            {
                con.Open();

               
                string query = @"INSERT INTO eingangsrechnungen 
                     (ID, Rechnungsnummer, Lieferant, Beschreibung, Menge, Erstellungsdatum, Faelligkeitsdatum, Betrag_Netto, USt, Betrag_Brutto, Status) 
                     VALUES (@ID, @Rechnungsnummer, @Lieferant, @Beschreibung, @Menge, @Erstellungsdatum, @Faelligkeitsdatum, @BetragNetto, @USt, @BetragBrutto, @Status)";

                cmd = new MySqlCommand(query, con);

               
                cmd.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                cmd.Parameters.AddWithValue("@Rechnungsnummer", txtRNr.Text.Trim());
                cmd.Parameters.AddWithValue("@Erstellungsdatum", dtpEDat.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Faelligkeitsdatum", dtpFDat.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@BetragNetto", Convert.ToDouble(txtBetragN.Text.Trim()));
                cmd.Parameters.AddWithValue("@USt", txtUst.Text.Trim());
                cmd.Parameters.AddWithValue("@BetragBrutto", Convert.ToDouble(txtBetragB.Text.Trim()));
                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@Lieferant", txtLieferant.Text.Trim());
                cmd.Parameters.AddWithValue("@Beschreibung", txtBeschreibung.Text.Trim());
                cmd.Parameters.AddWithValue("@Menge", Convert.ToInt32(txtMenge.Text.Trim()));

                
                anzahl = cmd.ExecuteNonQuery();

                if (anzahl > 0)
                {
                    MessageBox.Show("Datensatz erfolgreich hinzugefügt!");
                    RechnungenAnzeigen();
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

                    string query = "UPDATE eingangsrechnungen SET Rechnungsnummer = @Rechnungsnummer, Lieferant = @Lieferant, Beschreibung = @Beschreibung, Menge = @Menge, Erstellungsdatum = @Erstellungsdatum, Faelligkeitsdatum = @Faelligkeitsdatum, Betrag_Netto = @BetragNetto, USt = @USt, Betrag_Brutto = @BetragBrutto, Status = @Status WHERE ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@Rechnungsnummer", txtRNr.Text);
                        cmd.Parameters.AddWithValue("@Lieferant", txtLieferant.Text);
                        cmd.Parameters.AddWithValue("@Beschreibung", txtBeschreibung.Text);
                        cmd.Parameters.AddWithValue("@Menge", txtMenge.Text);
                        cmd.Parameters.AddWithValue("@Erstellungsdatum", dtpEDat.Value);
                        cmd.Parameters.AddWithValue("@Faelligkeitsdatum", dtpFDat.Value);
                        cmd.Parameters.AddWithValue("@BetragNetto", txtBetragN.Text);
                        cmd.Parameters.AddWithValue("@USt", txtUst.Text);
                        cmd.Parameters.AddWithValue("@BetragBrutto", txtBetragB.Text);
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@id", txtID.Text); 

                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Daten erfolgreich aktualisiert.");
                            txtID.Text = "";
                            txtLieferant.Text = "";
                            txtBeschreibung.Text = "";
                            txtMenge.Text = "";
                            txtBetragN.Text = "";
                            txtBetragB.Text = "";
                            txtUst.Text = "";
                            cmbStatus.Text = "";
                            RechnungenAnzeigen();
              
                        }
                        else
                        {
                            MessageBox.Show("Keine Datensätze aktualisiert. Bitte überprüfen Sie die ID.");
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
                cmd = new MySqlCommand("DELETE FROM eingangsrechnungen WHERE " + "ID = " + txtID.Text, con);

                anzahl = cmd.ExecuteNonQuery();

                if (anzahl > 0)
                {

                    MessageBox.Show("Datensatz gelöscht!");
                    txtID.Text = "";
                    txtLieferant.Text = "";
                    txtBeschreibung.Text = "";
                    txtMenge.Text = "";
                    txtBetragN.Text = "";
                    txtBetragB.Text = "";
                    txtUst.Text = "";
                    cmbStatus.Text = "";
                    RechnungenAnzeigen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ein Problem ist aufgetreten. Bitte versichern Sie sich, dass Sie alles richtig eingegeben haben. Wenn dies der Fall ist, bitte wenden Sie sich an den Admin.", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            RechnungenAnzeigen();
        }

        private void dgvBeschaffung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvBeschaffung.Rows[e.RowIndex];
                txtRNr.Text = row.Cells[1].Value.ToString();
                txtLieferant.Text = row.Cells[2].Value.ToString();
                txtBeschreibung.Text = row.Cells[3].Value.ToString();
                txtMenge.Text = row.Cells[4].Value.ToString();
                dtpEDat.Text = row.Cells[5].Value.ToString();
                dtpFDat.Text = row.Cells[6].Value.ToString();
                txtBetragN.Text = row.Cells[7].Value.ToString();
                txtUst.Text = row.Cells[8].Value.ToString();
                txtBetragB.Text = row.Cells[9].Value.ToString();
                cmbStatus.SelectedItem = row.Cells[10].Value.ToString();
                txtID.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}
