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
    public partial class Clients : Form
    {
        Football_DB db = new Football_DB();
        public Clients()
        {
            InitializeComponent();
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            string ClientName = txtClientAd.Text;
            string ClientLastname = txtClientSoyad.Text;
            string ClientPhone = txtClientNomre.Text;

            tbl_Musteri musteri = null;
            musteri = new tbl_Musteri
            {
                Ad = ClientName,
                Soyad = ClientLastname,
                Telefon = ClientPhone
            };

            db.tbl_Musteri.Add(musteri);
            db.SaveChanges();
            MessageBox.Show("Musteri Elave Edildi");
            
        }
    }
}
