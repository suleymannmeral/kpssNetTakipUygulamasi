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
using System.Threading;

namespace kpssNetTakip
{
    public partial class kayıtOl : Form
    {
        public kayıtOl()
        {
            InitializeComponent();
        }
         
        database db = new database();

        private void kayıtOl_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            passwordButton.Image = imageList1.Images[1]; // pasword visible icon
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Boş Geçilemez");
            }
            else
            {
                SqlConnection baglanti = new SqlConnection(db.adres);
                baglanti.Open();
                SqlCommand cmd3 = new SqlCommand("Insert Into TABLE_login (userName,password) values (@e1,@e2)", baglanti);
                cmd3.Parameters.AddWithValue("@e1", txtUserName.Text);
                cmd3.Parameters.AddWithValue("@e2", txtPassword.Text);
                cmd3.ExecuteNonQuery();
                baglanti.Close();



                DialogResult res = MessageBox.Show("Kaydınız Başarılı Bir Şekilde Gerçekleştirildi. Giriş Ekranına Dönmek İster Misiniz?", "Dikkat",
    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();

                }
                else if (res == DialogResult.Cancel)
                {
                    this.Show();
                    txtPassword.Text = "";
                    txtUserName.Text = "";

                }
            }




        }

        int count1 = 1; // for password visible
        private void passwordButton_Click(object sender, EventArgs e)
        {

            // password visible and button image
            count1++;
            if (count1 % 2 == 0)
            {
                txtPassword.UseSystemPasswordChar = false;
                passwordButton.Image = imageList1.Images[0];
            }
            if (count1 % 2 == 1)
            {
                txtPassword.UseSystemPasswordChar = true;
                passwordButton.Image = imageList1.Images[1];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();    
            frm.Show();
            this.Hide();
        }
    }
}
