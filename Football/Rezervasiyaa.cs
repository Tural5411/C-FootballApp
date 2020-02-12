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
    public partial class Rezervasiyaa : Form
    {
        Football_DB db = new Football_DB();
        public Rezervasiyaa()
        {
            InitializeComponent();
        }


        private void btnRez_Click(object sender, EventArgs e)
        {
            string RezAd = txtRezAd.Text;
            string RezSoyad = txtRezSoyad.Text;
            string RezNomre = txtRezNomre.Text;
            string MeydanAd = CmbMeydan.Text;
            string MeydanNomr = cmbRezMeydanNomr.Text;
            string OtaqNomre = cmbRezOtaqNomre.Text;
            DateTime DateFrom = dateFrom.Value;
            DateTime DateTo = dateToo.Value;
            int phoneNumber;
            if (Extension.isNotEmpty(new string[] {
                RezAd,RezSoyad,RezNomre,MeydanAd,MeydanNomr,OtaqNomre
            }, string.Empty)) ;
            {
                if(db.tbl_Otag.Any(otg=>otg.Musteri_sayi <= 12))
                {
                    if(int.TryParse(RezNomre, out phoneNumber))
                    {
                        tbl_Otag selectedOtaq = db.tbl_Otag.First(ot => ot.OtagNomre == OtaqNomre);
                        tbl_Meydan selectedMeydn = db.tbl_Meydan.First(myd => myd.Meydan_nomresi == MeydanNomr);

                        tbl_Musteri selectClient = null;
                        int ClientId = 0;

                        selectClient = db.tbl_Musteri.Add(new tbl_Musteri
                        {
                            Ad = RezAd,
                            Soyad = RezSoyad,
                            Telefon = RezNomre
                        });
                        db.SaveChanges();
                        MessageBox.Show("ELAVE OLDU");
                    }
                }
            }
        }

        public void FillCmbMeydan()
        {
            CmbMeydan.Items.AddRange(db.tbl_Meydan.Select(myd => myd.Meydan_Adi).ToArray());
        }

        public void FillCmbMeydanNomresi()
        {
            cmbRezMeydanNomr.Items.AddRange(db.tbl_Meydan.Select(nmr => nmr.Meydan_nomresi).ToArray());
        }

        public void FillCmbOtagNomresi()
        {
            cmbRezOtaqNomre.Items.AddRange(db.tbl_Otag.Select(ot => ot.OtagNomre).ToArray());
        }

        private void Rezervasiyaa_Load(object sender, EventArgs e)
        {
            FillCmbMeydan();
            FillCmbOtagNomresi();
            FillCmbMeydanNomresi();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
