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
    public partial class egitimbimleri : Form
    {
        public egitimbimleri()
        {
            InitializeComponent();
        }

         database db = new database();

        private void oabtDeneme_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            foreach (Control a in this.Controls)
            {
                if (a is Label && a.Text == "0000")
                {
                    a.Text = "";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            denemeSecimEkranı frm = new denemeSecimEkranı();
            frm.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                //gelişim psikolojisi

                int gpDog = Convert.ToInt32(txtGPdogru.Text);
                int gpYnls = Convert.ToInt32(txtGPyanlıs.Text);
                int gpBos = Convert.ToInt32(txtGPbos.Text);
                double gpNet = gpDog - 0.25 * gpYnls;
                txtGPnet.Text = gpNet.ToString();

                // Ogrenme psikolojisi

                int opDog = Convert.ToInt32(txtOPdogru.Text);
                int opYnls = Convert.ToInt32(txtOPy.Text);
                int opBos = Convert.ToInt32(txtOPbos.Text);
                double opNet = opDog - 0.25 * opYnls;
                txtOPnet.Text = opNet.ToString();

                // program geliştirme 

                int pgDog = Convert.ToInt32(txtPGdogru.Text);
                int pgYnls = Convert.ToInt32(txtPGyanlıs.Text);
                int pgBos = Convert.ToInt32(txtGPbos.Text);
                double pgNet = pgDog - 0.25 * pgYnls;
                txtPGnet.Text = pgNet.ToString();

                // oıvy

                int oıDog = Convert.ToInt32(txtOIdogru.Text);
                int oıYnls = Convert.ToInt32(txtOIy.Text);
                int oıBos = Convert.ToInt32(txtOIbos.Text);
                double oıNet = oıDog - 0.25 * oıYnls;
                txtOInet.Text = oıNet.ToString();

                //ovd

                int ovdDog = Convert.ToInt32(txtODdogru.Text);
                int ovdYnls = Convert.ToInt32(txtODyanlıs.Text);
                int ovdBos = Convert.ToInt32(txtODbos.Text);
                double ovdNet = ovdDog - 0.25 * ovdYnls;
                label19.Text = ovdNet.ToString();

                // rehberlik

                int rehbDog = Convert.ToInt32(txtRehbDogru.Text);
                int rehbYnls = Convert.ToInt32(txtRehbYanlıs.Text);
                int rehbBos = Convert.ToInt32(txtRehbBos.Text);
                double rehbNet = rehbDog - 0.25 * rehbYnls;
                txtRehbNet.Text = rehbNet.ToString();

                // Toplam

                topDogru.Text = (rehbDog + ovdDog + oıDog + pgDog + opDog + gpDog).ToString(); //dogru
                topYnalıs.Text = (rehbYnls + ovdYnls + oıYnls + pgYnls + opYnls + gpYnls).ToString(); // yanlıs
                topBos.Text = (rehbBos + ovdBos + oıBos + pgBos + opBos + gpBos).ToString();          //bos
                topNet.Text = (rehbNet + ovdNet + oıNet + pgNet + opNet + gpNet).ToString(); //net

            }

            catch
            {
                MessageBox.Show(" EKsik Veya Hatalı Giriş Yaptınız", "SM Software", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }






        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            txtGPnet.Text = "";
            txtOPnet.Text = "";
            txtPGnet.Text = "";
            txtOInet.Text = "";
            txtRehbNet.Text = "";
            label19.Text = "";
            topDogru.Text = "";
            topNet.Text = "";
            topYnalıs.Text = "";
            topBos.Text = "";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(db.adres);



            // egiitmb kaydetme
            baglanti.Open();


            SqlCommand cmd2 = new SqlCommand("Insert Into TBL_egitimbilimleriDeneme (Tarih,[Deneme Adı] , Süre,[Gelişim Psikolojisi],[Öğrenme Psikolojisi],[Program Geliştirme],ÖİVY,ÖVD,Rehberlik,Toplam) values(@k1,@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9,@k10)", baglanti);
            cmd2.Parameters.AddWithValue("@k1", textBox1.Text);
            cmd2.Parameters.AddWithValue("@k2", txtYayın.Text);
            cmd2.Parameters.AddWithValue("@k3", txtSure.Text);
            cmd2.Parameters.AddWithValue("@k4", txtGPnet.Text);
            cmd2.Parameters.AddWithValue("@k5", txtOPnet.Text);
            cmd2.Parameters.AddWithValue("@k6", txtOPnet.Text);
            cmd2.Parameters.AddWithValue("@k7", txtOInet.Text);
            cmd2.Parameters.AddWithValue("@K8", label19.Text);
            cmd2.Parameters.AddWithValue("@k9", txtRehbNet.Text);
            cmd2.Parameters.AddWithValue("@k10", topNet.Text);
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Netleriniz Başarılı Bir Şekilde Kayıt Edilmiştir", "SM Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    }

