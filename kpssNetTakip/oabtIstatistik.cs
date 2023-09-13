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
    public partial class oabtIstatistik : Form
    {
        public oabtIstatistik()
        {
            InitializeComponent();
        }
          database db = new database();



        private void oabtIstatistik_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(db.adres);

            this.CenterToScreen();
            //ort net
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("Select CAST(AVG(Toplam) AS Decimal(4,2)) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr1= cmd1.ExecuteReader();
            while(dr1.Read())
            {
                lblOrtNet.Text = dr1[0].ToString();
            }
            baglanti.Close();

            // en düşük deneme net
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select MIN(Toplam) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr2= cmd2.ExecuteReader();
            while(dr2.Read())
            {
                lblMINnet.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // max net
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("Select MAX(Toplam) From TBL_oabtDeneme ",baglanti);
            SqlDataReader dr3= cmd3.ExecuteReader();
            while(dr3.Read())
            {
                lblMaxNet.Text = dr3[0].ToString();
            }
            baglanti.Close();

            // ort süre
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("Select cast(AVG(Süre) as decimal(5,2)) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr4= cmd4.ExecuteReader();
            while( dr4.Read())
            {
                lblSure.Text = dr4[0].ToString();
            }
            baglanti.Close();

            // min sure 
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("Select MIN(Süre) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while(dr5.Read())
            {
                lblMınSure.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //max sure
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("Select MAX(Süre) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while(dr6.Read())
            {
                lblMaxSure.Text = dr6[0].ToString();
            }
            baglanti.Close();

            // top deneme sayısı
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("Select Count(Yayın) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while( dr7.Read())
            {
                lblCountDeneme.Text = dr7[0].ToString();
            }
            baglanti.Close();

            // fizik
            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("Select CAST(AVG(Fizik) AS Decimal(4,2)) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            while(dr8.Read())
            {
                lblFizik.Text = dr8[0].ToString();
            }
            baglanti.Close();

            //KİMYA
            baglanti.Open();
            SqlCommand cmd9 = new SqlCommand("Select CAST(AVG(Kimya) as Decimal(4,2))  From TBL_oabtDeneme", baglanti);
            SqlDataReader dr9 = cmd9.ExecuteReader();
            while(dr9.Read())
            {
                lblKimya.Text = dr9[0].ToString();  
            }
            baglanti.Close();

            // biyoloji

            baglanti.Open();
            SqlCommand cmd10 = new SqlCommand("Select CAST(AVG(Biyoloji) AS Decimal(4,2)) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr10 = cmd10.ExecuteReader();
            while(dr10.Read())
            {
                lblBiyoloji.Text = dr10[0].ToString();
            }
            baglanti.Close();

            // jeoloji

            baglanti.Open();
            SqlCommand cmd11 = new SqlCommand("Select CAST(AVG(Jeoloji) as Decimal(4,2)) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr11 = cmd11.ExecuteReader();
            while(dr11.Read())
            {
                lblJeoloji.Text= dr11[0].ToString();
            }
            baglanti.Close();

            // astronomi
            baglanti.Open();
            SqlCommand cmd12 = new SqlCommand("Select CAST(AVG(Astronomi) as Decimal(4,2)) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr12 = cmd12.ExecuteReader();
            while(dr12.Read())
            {
                lblAsronomi.Text= dr12[0].ToString();
            }
            baglanti.Close();

            // ÇEVRE Bilimi
            baglanti.Open();
            SqlCommand cmd13 = new SqlCommand("Select CAST(AVG([Çevre Bilimi]) as Decimal(4,2)) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr13 = cmd13.ExecuteReader();
            while(dr13.Read())
            {
                lblCB.Text= dr13[0].ToString();
            }
            baglanti.Close();

            // alan eğitimi
            baglanti.Open();
            SqlCommand cmd14 = new SqlCommand("Select CAST(AVG([Alan Eğitimi]) as Decimal(4,2)) From TBL_oabtDeneme", baglanti);
            SqlDataReader dr14 = cmd14.ExecuteReader();
            while(dr14.Read())
            {
                lblAE.Text= dr14[0].ToString();
            }
            baglanti.Close();




                





           
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            denemeIstatistikDetay frm1 = new denemeIstatistikDetay();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpFizik frm = new grpFizik();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grpKimya grpKimya = new grpKimya();
            grpKimya.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grpBiyoloji frmb = new grpBiyoloji();
            frmb.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grpJeoloji frmj = new grpJeoloji();
            frmj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grpAstr frma = new grpAstr();
            frma.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            grpCevreBilimi frmg = new grpCevreBilimi();
            frmg.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            grpAlanEgt frm = new grpAlanEgt();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            oabtSure frm = new oabtSure();
            frm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            oabtTopOrt oabtTopOrt = new oabtTopOrt();
            oabtTopOrt.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            oabtCount frm = new oabtCount();
            frm.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            denemeIstatistikDetay frm = new denemeIstatistikDetay();
            frm.Show();
            this.Hide();
        }
    }
}
