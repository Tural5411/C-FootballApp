using Football.Model;
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
    public partial class Rooms : Form
    {
        Football_DB db = new Football_DB();
        public Rooms()
        {
            InitializeComponent();
        }

        public void FillDataGrid()
        {
            dataGridView1.DataSource = db.tbl_Otag.Select(otg => new
            {
                otg.OtagNomre,
                otg.Musteri_sayi
                
            }).ToList();
        }

        private void btnOtagElaveEt_Click(object sender, EventArgs e)
        {
            string number = txtOtagNomresi.Text;
            int clientCount =(int)numMusteriSay.Value;

            if(number != string.Empty && clientCount != 0)
            {
                tbl_Otag otg = null;
                otg = new tbl_Otag
                {
                    OtagNomre = number,
                    Musteri_sayi = clientCount
                };
                db.tbl_Otag.Add(otg);
                db.SaveChanges();
                MessageBox.Show(otg.OtagNomre + "" + "nomreli" + "" +  "Otaq əlavə edildi", "OTAQ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGrid();
            }
            else
            {
                lblerror.Visible = true;
                MessageBox.Show("Xahis olunur butun setirleri doldurun", "SEHV",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
