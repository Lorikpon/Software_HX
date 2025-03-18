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
    public partial class Lager : Form
    {
        public Lager()
        {
            InitializeComponent();
        }

        private void Lager_Load(object sender, EventArgs e)
        {

        }

        private void cmdLagerAnsehen_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=homextra_user;UID=root"))
                {
                    con.Open();

                    // Abfrage der Lagerdaten
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM lager", con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Formatierung der Datumswerte (falls erforderlich)
                    foreach (DataColumn column in table.Columns)
                    {
                        if (column.DataType == typeof(DateTime))
                        {
                            // Hier kannst du das gewünschte Datumsformat angeben
                            column.ColumnName += "YYYY-MM-DD"; // Beispiel für die Umbenennung
                        }
                    }

                    dgvLager.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MAAnsicht mAAnsicht = new MAAnsicht();
            mAAnsicht.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LagerEntnahme lagerEntnahme = new LagerEntnahme();
            lagerEntnahme.Show();
            this.Hide();
        }
    }
}
