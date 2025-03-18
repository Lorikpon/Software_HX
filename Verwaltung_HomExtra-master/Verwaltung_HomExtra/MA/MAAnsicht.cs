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
    public partial class MAAnsicht : Form
    {
        public MAAnsicht()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Kreditoren kreditoren = new Kreditoren();
            kreditoren.Show();
            this.Hide();
        }

        private void lblXDashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDebDashboard_Click(object sender, EventArgs e)
        {
            Debitoren debitoren = new Debitoren();
            debitoren.Show();
            this.Hide();
        }

        private void lblAbmeldenDashboard_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void lblBeschDashboard_Click(object sender, EventArgs e)
        {
            Beschaffung beschaffung = new Beschaffung();
            beschaffung.Show();
            this.Hide();
        }

        private void lblVertriebDashboard_Click(object sender, EventArgs e)
        {
            Vertrieb vertrieb = new Vertrieb();
            vertrieb.Show();
            this.Hide();
        }

        private void lblLagerDashboard_Click(object sender, EventArgs e)
        {
            Lager lager = new Lager();
            lager.Show();
            this.Hide();
        }
    }
}
