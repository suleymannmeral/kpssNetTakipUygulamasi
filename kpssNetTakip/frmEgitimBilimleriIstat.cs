using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kpssNetTakip
{
    public partial class frmEgitimBilimleriIstat : Form
    {
        public frmEgitimBilimleriIstat()
        {
            InitializeComponent();
        }
             
        database db = new database();

        private void frmEgitimBilimleriIstat_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(db.adres);

            this.CenterToScreen();

            //ortalama netim
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(" Select CAST(Avg(Toplam) AS Decimal(4,2)) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblOrtNet.Text = dr[0].ToString();
            }
            baglanti.Close();

            // en düşük net
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select MIN(Toplam) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblMINnet.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //en yüksek net
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand(" Select MAX(Toplam) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while(dr3.Read())
            {
                lblMaxNet.Text = dr3[0].ToString();
            }
            baglanti.Close();

            // ortalama süre
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("Select CAST(AVG(Süre) as decimal(5,2)) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while(dr4.Read())
            {
                lblSure.Text = dr4[0].ToString();
            }
            baglanti.Close();

            // minimum süre 
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("Select MIN(Süre) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while(dr5.Read())
            {
                lblMınSure.Text = dr5[0].ToString();
            }
            baglanti.Close();

            // max sure
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("Select MAX(Süre) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while(dr6.Read())      {
                lblMaxSure.Text = dr6[0].ToString();
            }
            baglanti.Close();

            // toplam deneme sayısı
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("Select Count([Deneme Adı]) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {
                lblCountDeneme.Text = dr7[0].ToString();
            }
            baglanti.Close();

            // GELİŞİM PSİKOLOJİSİ
            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("Select CAST(AVG([Gelişim Psikolojisi]) AS Decimal(4,2)) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            while (dr8.Read())
            {
                lblGP.Text= dr8[0].ToString();  

            }
            baglanti.Close();

            // ogrenme psikolojisi
            baglanti.Open();
            SqlCommand cmd9 = new SqlCommand("Select CAST(AVG([Öğrenme PSikolojisi]) AS DECIMAL(4,2)) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr9 = cmd9.ExecuteReader();
            while (dr9.Read())
            {
                LBLop.Text= dr9[0].ToString();
            }
            baglanti.Close();

            // program geliştirme
            baglanti.Open();
            SqlCommand cmd10 = new SqlCommand(" Select CAST(AVG([Program Geliştirme]) AS Decimal(4,2)) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr10 = cmd10.ExecuteReader();
            while (dr10.Read())
            {
                lblPG.Text= dr10[0].ToString(); 
            }
            baglanti.Close();

            // oıvy
            baglanti.Open();
            SqlCommand cmd11 = new SqlCommand("Select CAST(AVG(ÖİVY) AS DECIMAL(4,2)) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr11 = cmd11.ExecuteReader();
            while(dr11.Read())
            {
                LBLoıvy.Text= dr11[0].ToString();
            }
            baglanti.Close();

            //ovd
            baglanti.Open();
            SqlCommand cmd12 = new SqlCommand("Select CAST(AVG(ÖVD) AS DECIMAL(4,2)) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr12 = cmd12.ExecuteReader();
            while( dr12.Read())
            {
                lblOVD.Text= dr12[0].ToString();

            }
            baglanti.Close();

            // REHBERLİK
            baglanti.Open();
            SqlCommand cmd13 = new SqlCommand("Select CAST(AVG(Rehberlik) AS DECIMAL(4,2)) From TBL_egitimbilimleriDeneme", baglanti);
            SqlDataReader dr13 = cmd13.ExecuteReader();
            while(dr13.Read())
            {
                lblREHB.Text= dr13[0].ToString();
            }
            baglanti.Close();

        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            denemeIstatistikDetay frm = new denemeIstatistikDetay();
            frm.Show();
            this.Hide();
        }

        private void btnGPgraph_Click(object sender, EventArgs e)
        {
            frmGelisimPsikoGrafik frm = new frmGelisimPsikoGrafik();
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmogrPskGraph frm = new frmogrPskGraph();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProgramgelistirmeGraphcs frm = new frmProgramgelistirmeGraphcs();
            frm.Show();
            this.Hide();
        }

        private void btnOIVY_Click(object sender, EventArgs e)
        {
            oıvyGrafikAnaliz frm =  new oıvyGrafikAnaliz();
            frm.Show();
            this.Hide();
        }

        private void btnOVD_Click(object sender, EventArgs e)
        {
            frmOVDgrafik frm = new frmOVDgrafik();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rehberlikGrafikAnaliz frm = new rehberlikGrafikAnaliz();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSureEB frm = new frmSureEB();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            countDenemeEBcs frm = new countDenemeEBcs();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ortNetgrpEB cs = new ortNetgrpEB();
            cs.Show();
            this.Hide();
        }
    }
}
