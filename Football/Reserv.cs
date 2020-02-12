using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football
{
    public partial class Reserv : Form
    {
        public Reserv()
        {
            InitializeComponent();
        }

        private void btnRezervasiya_Click(object sender, EventArgs e)
        {
            Rezervasiyaa rezev = new Rezervasiyaa();
            rezev.ShowDialog();
        }

        private void btnMeydan_Click(object sender, EventArgs e)
        {
            Stadion std = new Stadion();
            std.ShowDialog();
        }

        private void btnOtag_Click(object sender, EventArgs e)
        {
            Rooms rms = new Rooms();
            rms.ShowDialog();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Clients cls = new Clients();
            cls.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
