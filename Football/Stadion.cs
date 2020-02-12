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
    public partial class Stadion : Form
    {
        Football_DB db = new Football_DB();
        public Stadion()
        {
            InitializeComponent();
        }

        public void FillDataGrid()
        {
            dataGridView1.DataSource = db.tbl_Meydan.Select(md => new
            {
                md.Meydan_Adi,
                md.Meydan_nomresi
                
            }).ToList();
        }
        private void btnMeydancaElaveEt_Click(object sender, EventArgs e)
        {
            string MeydancaAdi = txtMeydancaAdi.Text;
            string MeydacaNomresi = txtMeydancaNomresi.Text;

            if (Extension.isNotEmpty(new string[]
            {
                MeydancaAdi
            }, string.Empty))
            {
                
                    tbl_Meydan mydn = null;
                    mydn = new tbl_Meydan
                    {
                        Meydan_Adi = MeydancaAdi,
                        Meydan_nomresi = MeydacaNomresi


                    };
                    db.tbl_Meydan.Add(mydn);
                    db.SaveChanges();
                    FillDataGrid();
                MessageBox.Show("Elave Edildi", "MEYDAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        private void Stadion_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }



        tbl_Meydan AddMeydan = null;
        private void txtMeydancaNomresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            string mydnNmrsi = txtMeydancaNomresi.Text;
            if(e.KeyChar == 13)
            {
                //AddMeydan(mydnNmrsi);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
