using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace kpssNetTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int count1 = 1; // for password visible
        

        private void button1_Click(object sender, EventArgs e)
        {
            // password visible and button image
            count1++;
            if(count1%2==0)
            {
                txtPassword.UseSystemPasswordChar = false;
                passwordButton.Image = imageList1.Images[0];
            }
            if(count1%2==1)
            {
                txtPassword.UseSystemPasswordChar = true;
                passwordButton.Image = imageList1.Images[1];
            }
           


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordButton.Image = imageList1.Images[1]; // pasword visible icon
            this.CenterToScreen(); 
            txtUserName.Focus();
        }
        database db = new database();


        private void button1_Click_1(object sender, EventArgs e) // login olayı
        {

            SqlConnection baglanti = new SqlConnection(db.adres);


            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from TABLE_login where  userName=@p1 COLLATE SQL_Latin1_General_CP1_CS_AS   and password=@p2 COLLATE SQL_Latin1_General_CP1_CS_AS ", baglanti);
            cmd.Parameters.AddWithValue("@p1", txtUserName.Text);
            cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                islemSecimForm frm2 = new islemSecimForm();
                frm2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış","SM Software",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtUserName.Text = "";
                txtPassword.Text = "";

            }
            baglanti.Close();










        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayıtOl frm = new kayıtOl();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lisanGrafik frm = new lisanGrafik();
            frm.Show();
            this.Hide();
        }
    }
}
