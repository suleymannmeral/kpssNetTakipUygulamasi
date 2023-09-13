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
using System.Linq.Expressions;

namespace kpssNetTakip
{
    public partial class lisansDeneme : Form
    {
        public lisansDeneme()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            foreach (Control c in this.Controls)
            {
                if (c is Label&& c.Text=="0000")
                {
                    c.Text = "";
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            denemeSecimEkranı frm0 = new denemeSecimEkranı();
            frm0.Show();
            this.Hide();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {


                //Turkce

                double trD = Convert.ToDouble(txtTurkceDogru.Text);
                double trY = Convert.ToDouble(txtTurkceYanlıs.Text);
                int trBos=Convert.ToInt32(txtTurkceBos.Text);
                double trNet = trD - 0.25 * trY;
                lblTurkce.Text = trNet.ToString();

                //Matematik

                double matD = Convert.ToDouble(txtMatD.Text);
                double matY = Convert.ToDouble(txtMatY.Text);
                int matBos = Convert.ToInt32(txtMatB.Text);
                double matNet = matD - 0.25 * matY;
                lblMat.Text = matNet.ToString();

                //tarih

                double tarhD = Convert.ToDouble(txtTarihD.Text);
                double tarhY = Convert.ToDouble(txtTarihY.Text);
                int tarhBos = Convert.ToInt32(txtTarihB.Text);
                double tarhNet = tarhD - 0.25 * tarhY;
                lblTarh.Text = tarhNet.ToString();

                //Coğrafya

                double cogD = Convert.ToDouble(txtCogD.Text);
                double cogY=Convert.ToDouble(txtCogY.Text);
                int cogBos = Convert.ToInt32(txtCogB.Text);
                double cogNet = cogD - 0.25 * cogY;
                lblCogNet.Text = cogNet.ToString();

                // Vatandaşlık

                double vtnD= Convert.ToDouble(txtVatD.Text);
                double vtnY= Convert.ToDouble(txtVatY.Text);
                int vtnB = Convert.ToInt32(txtVatB.Text);
                double vtnNet = vtnD - 0.25 * vtnY;
                lblVtnNet.Text = vtnNet.ToString();

                // Guncel

                double guncelD= Convert.ToDouble(txtGuncD.Text);
                double guncelY=Convert.ToDouble(txtGuncY.Text);
                double guncelNet = guncelD - 0.25 * guncelY;
                int guncBos = Convert.ToInt32( txtGuncB.Text);
                lblGunc.Text = guncelNet.ToString();

                // toplam

                
                lblTopDog.Text= (cogD + trD + matD + guncelD + vtnD + tarhD).ToString(); //dogru

                lblTopYanlıs.Text=(cogY+trY+matY+guncelY+vtnY+tarhY).ToString(); //yanlıs

                lblTopBos.Text = (cogBos + matBos + guncBos + trBos + vtnB + tarhBos).ToString(); //bos

                lblTopNet.Text= (guncelNet+vtnNet+tarhNet+matNet+trNet+cogNet).ToString(); // net

                double gnK = trNet + matNet;
                label15.Text = gnK.ToString();

                double gnY = cogNet + guncelNet + vtnNet + tarhNet;
                label16.Text = gnY.ToString();



            }
            
            catch
            {
                MessageBox.Show(" EKsik Veya Hatalı Giriş Yaptınız", "SM Software", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        database db = new database();

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox25.Text=="")
            {
                MessageBox.Show("Deneme Yayını Girişi Yapmadınız","SM Software",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            SqlConnection baglanti = new SqlConnection(db.adres);



            baglanti.Open();
                SqlCommand cmd = new SqlCommand("Insert Into TBL_lisansDeneme (Tarihi,DenemeAd,Süre,Türkçe,Matematik,Tarih,Coğrafya,Vatandaşlık,Güncel,GenKtop,GenYtop,Toplam) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", baglanti);
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                cmd.Parameters.AddWithValue("@p2", textBox25.Text);
                cmd.Parameters.AddWithValue("@p3", txtSure.Text);
                cmd.Parameters.AddWithValue("@p4", lblTurkce.Text);
                cmd.Parameters.AddWithValue("@p5", lblMat.Text);
                cmd.Parameters.AddWithValue("@p6", lblTarh.Text);
                cmd.Parameters.AddWithValue("@p7", lblCogNet.Text);
                cmd.Parameters.AddWithValue("@p8", lblVtnNet.Text);
                cmd.Parameters.AddWithValue("@p9", lblGunc.Text);
                cmd.Parameters.AddWithValue("@p10", label15.Text);
                cmd.Parameters.AddWithValue("@p11", label16.Text);
                cmd.Parameters.AddWithValue("@p12", lblTopNet.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();   
            MessageBox.Show("Netleriniz Başarılı Bir Şekilde Kayıt Edilmiştir","SM Software",MessageBoxButtons.OK,MessageBoxIcon.Information);
            


            








        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblCogNet.Text = "";
            lblMat.Text = "";
            lblGunc.Text = "";
            lblTarh.Text = "";
            lblCogNet.Text = "";
            lblVtnNet.Text = "";
            lblTurkce.Text = "";
            lblTopBos.Text = "";
            lblTopDog.Text = "";
            lblTopYanlıs.Text = "";
            lblTopNet.Text = "";
            
            

            foreach (Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
