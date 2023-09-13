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
    public partial class matematikIst : Form
    {
        public matematikIst()
        {
            InitializeComponent();
        }
           database db = new database();

        private void matematikIst_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(db.adres);

            this.CenterToScreen();

            // Ekim
            baglanti.Open();
            SqlCommand cmdg2 = new SqlCommand("SELECT CAST(AVG(Matematik) AS decimal(4,2)) FROM TBL_lisansDeneme WHERE Tarihi BETWEEN '2023-10-01' AND '2023-10-31'", baglanti);
            SqlDataReader dr2 = cmdg2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Matematik"].Points.AddXY("Ekim", dr2[0]);
            }
            dr2.Close();
            baglanti.Close();

            // kasım

            baglanti.Open();
            SqlCommand cmdg3 = new SqlCommand("SELECT CAST(AVG(Matematik) AS decimal(4,2)) FROM TBL_lisansDeneme WHERE Tarihi BETWEEN '2023-11-01' AND '2023-11-30'", baglanti);
            SqlDataReader dr3 = cmdg3.ExecuteReader();
            while (dr3.Read())
            {
                chart1.Series["Matematik"].Points.AddXY("Kasım", dr3[0]);
            }
            dr3.Close();
            baglanti.Close();

            // Aralık
            baglanti.Open();
            SqlCommand cmdg4 = new SqlCommand("Select Cast(AVG(Matematik) As Decimal(4,2)) From TBL_lisansDeneme WHERE Tarihi Between '2023-12-01' AND '2023-12-31'", baglanti);
            SqlDataReader dr4 = cmdg4.ExecuteReader();
            while (dr4.Read())
            {
                chart1.Series["Matematik"].Points.AddXY("Aralık", dr4[0]);
            }
            dr4.Close();
            baglanti.Close();

            // OCAK 
            baglanti.Open();
            SqlCommand cmdg5 = new SqlCommand("Select Cast(AVG(Matematik) As Decimal(4,2)) From TBL_lisansDeneme WHERE Tarihi BETWEEN '2024-01-01' AND '2024-01-31'", baglanti);
            SqlDataReader dr5 = cmdg5.ExecuteReader();
            while (dr5.Read())
            {
                chart1.Series["Matematik"].Points.AddXY("Ocak", dr5[0]);
            }
            dr5.Close();
            baglanti.Close();

            // Şubat
            baglanti.Open();
            SqlCommand cmdg6 = new SqlCommand("Select Cast(AVG(Matematik) As Decimal(4,2)) From TBL_lisansDeneme WHERE Tarihi BETWEEN '2024-02-01' AND '2024-02-29'", baglanti);
            SqlDataReader dr6 = cmdg6.ExecuteReader();
            while (dr6.Read())
            {
                chart1.Series["Matematik"].Points.AddXY("Şubat", dr6[0]);
            }
            dr6.Close();
            baglanti.Close();

            // Mart
            baglanti.Open();
            SqlCommand cmdg7 = new SqlCommand("Select CAST(AVG(Matematik) As Decimal(4,2)) From tbl_lisansDeneme Where Tarihi Between '2024-03-01' AND '2024-03-31'", baglanti);
            SqlDataReader dr7 = cmdg7.ExecuteReader();
            while (dr7.Read())
            {
                chart1.Series["Matematik"].Points.AddXY("Mart", dr7[0]);
            }
            dr7.Close();
            baglanti.Close();

            // NİSAN 
            baglanti.Open();
            SqlCommand cmdg8 = new SqlCommand("Select CAST(AVG(Matematik) As Decimal(4,2)) From tbl_lisansDeneme Where Tarihi Between '2024-04-01' AND '2024-04-30'", baglanti);
            SqlDataReader dr8 = cmdg8.ExecuteReader();
            while (dr8.Read())
            {
                chart1.Series["Matematik"].Points.AddXY("Nisan", dr8[0]);
            }
            dr8.Close();
            baglanti.Close();

            // Mayıs 
            baglanti.Open();
            SqlCommand cmdg9 = new SqlCommand("Select CAST(AVG(Matematik) As Decimal(4,2)) From tbl_lisansDeneme Where Tarihi Between '2024-05-01' AND '2024-05-31'", baglanti);
            SqlDataReader dr9 = cmdg9.ExecuteReader();
            while (dr9.Read())
            {
                chart1.Series["Matematik"].Points.AddXY("Mayıs", dr9[0]);
            }
            dr9.Close();
            baglanti.Close();

            ////// Haziran

            baglanti.Open();
            SqlCommand cmdg10 = new SqlCommand("Select CAST(AVG(Matematik) As Decimal(4,2)) From tbl_lisansDeneme Where Tarihi Between '2024-06-01' AND '2024-06-30'", baglanti);
            SqlDataReader dr10 = cmdg10.ExecuteReader();
            while (dr10.Read())
            {
                chart1.Series["Matematik"].Points.AddXY("Haziran", dr10[0]);
            }
            dr10.Close();
            baglanti.Close();

            // Temmuz
            baglanti.Open();
            SqlCommand cmdg11 = new SqlCommand("Select CAST(AVG(Matematik) As Decimal(4,2)) From tbl_lisansDeneme Where Tarihi Between '2024-07-01' AND '2024-07-31'", baglanti);
            SqlDataReader dr11 = cmdg11.ExecuteReader();
            while (dr11.Read())
            {
                chart1.Series["Matematik"].Points.AddXY("Temmuz", dr11[0]);
            }
            dr11.Close();
            baglanti.Close();

            //au8gust

            baglanti.Open();
            SqlCommand cmdg12 = new SqlCommand("Select CAST(AVG(Matematik) As Decimal(4,2)) From tbl_lisansDeneme Where Tarihi Between '2024-08-01' AND '2024-08-31'", baglanti);
            SqlDataReader dr12 = cmdg12.ExecuteReader();
            while (dr12.Read())
            {
                chart1.Series["Matematik"].Points.AddXY("Ağustos", dr12[0]);
            }
            dr12.Close();
            baglanti.Close();




        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {

            // Home Screen Buttonlsdfksd

            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            lisansDenemeIst frm1 = new lisansDenemeIst();
            frm1.Show();
            this.Hide();
        }

        private void matematikIst_FormClosed(object sender, FormClosedEventArgs e)
        {
            lisansDenemeIst frm = new lisansDenemeIst();
            frm.Show();
            this.Hide();
        }
    }
}
