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
    public partial class Form1 : Form

    {

        Football_DB db = new Football_DB();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string passwrod = txtPassword.Text;

            if (email != null && passwrod != null)
            {
                tbl_Admin Selectadmin = db.tbl_Admin.FirstOrDefault(ad => ad.Email == email);
                if (Selectadmin != null)
                {
                    if (Selectadmin.Password == passwrod)
                    {
                        Reserv rsv = new Reserv();
                        rsv.ShowDialog();
                    }
                    else
                    {
                        lblerror.Visible = true;
                        lblerror.Text = "Sifre yalnisdir ";
                    }
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "Email yalnisdir";
                }
            }
           

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeicon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point  lastpoint;
        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void closeicon_MouseDown(object sender, MouseEventArgs e)
        {

            lastpoint = new Point(e.X, e.Y);
        }


        private void closeicon_MouseEnter(object sender, EventArgs e)
        {
            closeicon.BackColor = Color.Red;

        }

        private void closeicon_MouseLeave(object sender, EventArgs e)
        {
            closeicon.BackColor = Color.White;
        }

       
    }
}
