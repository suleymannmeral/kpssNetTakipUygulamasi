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
    public partial class grpJeoloji : Form
    {
        public grpJeoloji()
        {
            InitializeComponent();
        }
        database db = new database();


        private void grpJeoloji_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(db.adres);

            this.CenterToScreen();
            // Ekim
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select CAST(AVG(Jeoloji) AS Decimal(4,2)) From TBL_oabtDeneme Where tarih Between '2023-10-01' And '2023-10-31'", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Jeoloji"].Points.AddXY("Ekim", dr[0]);
            }
            dr.Close();
            baglanti.Close();

            // Kasım 
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select CAST(AVG(Jeoloji) AS Decimal(4,2)) From TBL_oabtDeneme Where tarih Between '2023-11-01' And '2023-11-30'", baglanti);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Jeoloji"].Points.AddXY("Kasım", dr2[0]);
            }
            dr2.Close();
            baglanti.Close();

            // Aralık
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("Select CAST(AVG(Jeoloji) AS Decimal(4,2)) From TBL_oabtDeneme Where tarih Between '2023-12-01' And '2023-12-31'", baglanti);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                chart1.Series["Jeoloji"].Points.AddXY("Aralık", dr3[0]);
            }
            dr3.Close();
            baglanti.Close();

            // Ocak

            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("Select CAST(AVG(Jeoloji) AS Decimal(4,2)) From TBL_oabtDeneme Where tarih Between '2024-01-01' And '2024-01-31'", baglanti);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                chart1.Series["Jeoloji"].Points.AddXY("Ocak", dr4[0]);
            }
            dr4.Close();
            baglanti.Close();

            // Şubat
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("Select CAST(AVG(Jeoloji) AS Decimal(4,2)) From TBL_oabtDeneme Where tarih Between '2024-02-01' And '2024-02-29'", baglanti);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                chart1.Series["Jeoloji"].Points.AddXY("Şubat", dr5[0]);
            }
            dr5.Close();
            baglanti.Close();

            // Mart
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("Select CAST(AVG(Jeoloji) AS Decimal(4,2)) From TBL_oabtDeneme Where tarih Between '2024-03-01' And '2024-03-31'", baglanti);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                chart1.Series["Jeoloji"].Points.AddXY("Mart", dr6[0]);
            }
            dr6.Close();
            baglanti.Close();

            //Nisan
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("Select CAST(AVG(Jeoloji) AS Decimal(4,2)) From TBL_oabtDeneme Where tarih Between '2024-04-01' And '2024-04-30'", baglanti);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {
                chart1.Series["Jeoloji"].Points.AddXY("Nisan", dr7[0]);
            }
            dr7.Close();
            baglanti.Close();

            // Mayıs 
            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("Select CAST(AVG(Jeoloji) AS Decimal(4,2)) From TBL_oabtDeneme Where tarih Between '2024-05-01' And '2024-05-31'", baglanti);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            while (dr8.Read())
            {
                chart1.Series["Jeoloji"].Points.AddXY("Mayıs", dr8[0]);
            }
            dr8.Close();
            baglanti.Close();

            // Haziran 
            baglanti.Open();
            SqlCommand cmd9 = new SqlCommand("Select CAST(AVG(Jeoloji) AS Decimal(4,2)) From TBL_oabtDeneme Where tarih Between '2024-06-01' And '2024-06-30'", baglanti);
            SqlDataReader dr9 = cmd9.ExecuteReader();
            while (dr9.Read())
            {
                chart1.Series["Jeoloji"].Points.AddXY("Haziran", dr9[0]);
            }
            dr9.Close();
            baglanti.Close();

            //Temmuz 
            baglanti.Open();
            SqlCommand cmd10 = new SqlCommand("Select CAST(AVG(Jeoloji) AS Decimal(4,2)) From TBL_oabtDeneme Where tarih Between '2024-07-01' And '2024-07-31'", baglanti);
            SqlDataReader dr10 = cmd10.ExecuteReader();
            while (dr10.Read())
            {
                chart1.Series["Jeoloji"].Points.AddXY("Temmuz", dr10[0]);
            }
            dr10.Close();
            baglanti.Close();

            // Ağustos
            baglanti.Open();
            SqlCommand cmd11 = new SqlCommand("Select CAST(AVG(Jeoloji) AS Decimal(4,2)) From TBL_oabtDeneme Where tarih Between '2024-08-01' And '2024-08-30'", baglanti);
            SqlDataReader dr11 = cmd11.ExecuteReader();
            while (dr11.Read())
            {
                chart1.Series["Jeoloji"].Points.AddXY("Ağustos", dr11[0]);
            }
            dr11.Close();
            baglanti.Close();


        }

        private void grpJeoloji_FormClosed(object sender, FormClosedEventArgs e)
        {
            oabtIstatistik frm = new oabtIstatistik();
            frm.Show();
            this.Hide();
        }
    }
}
