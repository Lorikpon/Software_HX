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

            con.ConnectionString = "Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root";

            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM eingangsrechnungen", con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvBeschaffung.DataSource = table;
        }

        private void cmdRechnungErstellen_Click(object sender, EventArgs e)
        {
            int anzahl;
            MySqlConnection con = new MySqlConnection("Data Source=localhost;" + "Initial Catalog=homextra_user;UID=root");
            MySqlCommand cmd;




            try
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO eingangsrechnungen (ID, Rechnungsnummer, Erstellungsdatum, Faelligkeitsdatum, Betrag, Status, Lieferant, Beschreibung) " +
                    "VALUES ('" + txtID.Text + "', '" + txtRNr.Text + "', '" + dtpEDat.Value + "', '" + dtpFDat.Value + "', '" + Convert.ToDouble(txtBetrag.Text) + "', '" +
                    Convert.ToString(cmbStatus.SelectedIndex) + "', '" + txtLieferant.Text + "', '" + txtBeschreibung.Text + "')", con);

                anzahl = cmd.ExecuteNonQuery();

                if (anzahl > 0)
                {
                    MessageBox.Show("Datensatz hinzugefügt!");
                   
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
            RechnungenAnzeigen();

        }
    }
}
