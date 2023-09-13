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

namespace kpssNetTakip
{
    public partial class lisansDenemeIst : Form
    {
        public lisansDenemeIst()
        {
            InitializeComponent();
        }
            database db = new database();

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void lisansDenemeIst_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(db.adres);

            this.CenterToScreen();
            // ortalama net
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT CAST(AVG(Toplam) AS DECIMAL(4,2)) FROM TBL_lisansDeneme ", baglanti);
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                lblOrtNet.Text = dr[0].ToString();


            }
            baglanti.Close();

            // ort süre
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand(" Select CAST(AVG(Süre) AS DECIMAL(5,2))  From TBL_lisansDeneme", baglanti);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblSure.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // min süre
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand(" Select MIN(Süre) From TBL_lisansDeneme", baglanti);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while(dr3.Read())
            {
                lblMınSure.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //max sure
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand(" Select MAX(Süre) From TBL_lisansDeneme ", baglanti);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while( dr4.Read())
            {
                lblMaxSure.Text = dr4[0].ToString();
            }
            baglanti.Close();

            // en dusuk deneme neti
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("Select MIN(Toplam) From TBL_lisansDeneme", baglanti);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while(dr5.Read())
            {
                lblMINnet.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //en yuksek deneme net
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("Select MAX(Toplam) From TBL_lisansDeneme", baglanti);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while(dr6.Read())
            {
                lblMaxNet.Text = dr6[0].ToString();
            }
            baglanti.Close();

            // toplam deneme
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("Select COUNT(DenemeAd) From TBL_lisansDeneme", baglanti);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while( dr7.Read())
            {
                lblCountDeneme.Text = dr7[0].ToString();
            }
            baglanti.Close();

            // turkce net ortalaması
            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("Select CAST(AVG(Türkçe) AS DECIMAL(4,2)) From TBL_lisansDeneme ", baglanti);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            while(dr8.Read())
            {
                lblTurkce.Text = dr8[0].ToString();
            }
            baglanti.Close();

            // matematik ort
            baglanti.Open();
            SqlCommand cmd9 = new SqlCommand("Select CAST(AVG(Matematik) AS DECIMAL(4,2)) From TBL_lisansDeneme", baglanti);
            SqlDataReader dr9 = cmd9.ExecuteReader();
            while(dr9.Read())
            {
                lblMat.Text= dr9[0].ToString();
            }
            baglanti.Close();

            // gKORT 
            baglanti.Open();
            SqlCommand cmd10 = new SqlCommand("Select CAST(AVG(GenKTop) AS DECIMAL(5,2)) From TBL_lisansDeneme", baglanti);
            SqlDataReader dr10 = cmd10.ExecuteReader();
            while(dr10.Read())
            {
                gyOrt.Text = dr10[0].ToString();    
            }
            baglanti.Close();

            // tarih
            baglanti.Open();
            SqlCommand cmd11 = new SqlCommand("Select CAST(AVG(Tarih) AS DECIMAL(4,2)) From TBL_lisansDeneme", baglanti);
            SqlDataReader dr11 = cmd11.ExecuteReader();
            while(dr11.Read())
            {
                lblTarih.Text = dr11[0].ToString();
            }
            baglanti.Close();

            //cografya
            baglanti.Open();
            SqlCommand cmd12 = new SqlCommand("Select CAST(AVG(Coğrafya) AS DECIMAL(4,2)) From TBL_lisansDeneme", baglanti);
            SqlDataReader dr12 = cmd12.ExecuteReader();
            while(dr12.Read())
            {
                lblCog.Text = dr12[0].ToString();
            }
            baglanti.Close();

            // vatandaşlık 
            baglanti.Open();
            SqlCommand cmd13 = new SqlCommand("Select CAST(AVG(Vatandaşlık) AS DECIMAL(4,2)) From TBL_lisansDeneme", baglanti);
            SqlDataReader dr13 = cmd13.ExecuteReader();
            while(dr13.Read())
            {
                lblVTN.Text = dr13[0].ToString();
            }
            baglanti.Close();

            // güncel
            baglanti.Open();
            SqlCommand cmd14 = new SqlCommand("Select CAST(AVG(Güncel) AS DECIMAL(4,2)) From TBL_lisansDeneme", baglanti);
            SqlDataReader dr14 = cmd14.ExecuteReader();
            while(dr14.Read())
            {
                lblGuncel.Text = dr14[0].ToString();
            }
            baglanti.Close();

            // gy ort
            baglanti.Open();
            SqlCommand cmd15 = new SqlCommand(" Select CAST(AVG(GenYTop) AS DECIMAL(5,2)) From TBL_lisansDeneme", baglanti);
            SqlDataReader dr15 = cmd15.ExecuteReader();
            while(dr15.Read())
            {
                henYnet.Text = dr15[0].ToString();
            }
            baglanti.Close();













        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            denemelerimSecim frm = new denemelerimSecim();
            frm.Show();
            this.Hide();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            denemeIstatistikDetay frm = new denemeIstatistikDetay();
            frm.Show();
            this.Hide();
        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            lisanGrafik frm = new lisanGrafik();
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            matematikIst drm = new matematikIst();
            drm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // coğrafya grafik
            tarihGrafik frm = new tarihGrafik();
            frm.Show();
            this.Hide();
        }

        private void btnVat_Click(object sender, EventArgs e)
        {
            vatandsGrafik frm = new vatandsGrafik();
            frm.Show();
            this.Hide();
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            guncelGrafik  guncelGrafik = new guncelGrafik();
                guncelGrafik.Show();
            this.Hide();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            sureGrafik frm = new sureGrafik();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            genelKGrafik g = new genelKGrafik();
            g.Show();
            this.Hide();
        }

        private void btnGY_Click(object sender, EventArgs e)
        {
            genYGrafik fy = new genYGrafik();
            fy.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmTopLisGrafcs g = new frmTopLisGrafcs();
            g.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            topOrtLisans frm  = new topOrtLisans();
            frm.Show();
            this.Hide();
        }
    }
}
