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
    public partial class frmOABT : Form
    {
        public frmOABT()
        {
            InitializeComponent();
        }


        private void frmOABT_Load(object sender, EventArgs e)
        {
           
            this.CenterToScreen();
            
            foreach(Control  a in this.Controls)
            {
                if(a is Label && a.Text=="0000")
                {
                    a.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            denemeSecimEkranı frm = new denemeSecimEkranı();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 frmhp = new Form1();
            frmhp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            denemeSecimEkranı frmds = new denemeSecimEkranı();
            frmds.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtYayın.Text == "" || textBox1.Text == "" || txtSure.Text == "")
            {
                MessageBox.Show(" Eksik Veya Hatalı Giriş Yaptınız", "SM Software", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                try
                {


                    // Fizik
                    int fizikD = Convert.ToInt32(txtFizikD.Text);
                    int fizikY = Convert.ToInt32(txtFizikY.Text);
                    int fizikB = Convert.ToInt32(txtFizikB.Text);
                    double fizikN = fizikD - 0.25 * fizikY;
                    lblFizikNet.Text = fizikN.ToString();

                    // Kimya
                    int kimyaD = Convert.ToInt32(txtKimyaD.Text);
                    int kimyaY = Convert.ToInt32(txtKimyaY.Text);
                    int kimyaB = Convert.ToInt32(txtKimyaB.Text);
                    double kimyaN = kimyaD - 0.25 * kimyaY;
                    lblKimyaNet.Text = kimyaN.ToString();

                    //Biyoloji
                    int bioD = Convert.ToInt32(txtBioD.Text);
                    int bioY = Convert.ToInt32(txtBioY.Text);
                    int bioB = Convert.ToInt32(txtBioB.Text);
                    double bioN = bioD - 0.25 * bioY;
                    lblBioNet.Text = bioN.ToString();

                    //Jeoloji
                    int jeoD = Convert.ToInt32(txtJeoD.Text);
                    int jeoY = Convert.ToInt32(txtJeoY.Text);
                    int jeoB = Convert.ToInt32(txtJeoB.Text);
                    double jeoN = jeoD - 0.25 * jeoY;
                    lblJeoNet.Text = jeoN.ToString();

                    //Astronomi
                    int astD = Convert.ToInt32(txtAstD.Text);
                    int astY = Convert.ToInt32(txtAstY.Text);
                    int astB = Convert.ToInt32(txtAstB.Text);
                    double astN = astD - 0.25 * astY;
                    lblAstNet.Text = astN.ToString();

                    // Cevre Bilimi
                    int cbD = Convert.ToInt32(txtCbD.Text);
                    int cbY = Convert.ToInt32(txtCbY.Text);
                    int cbB = Convert.ToInt32(txtCbB.Text);
                    double cbN = cbD - 0.25 * cbY;
                    lblCbNet.Text = cbN.ToString();

                    //Alan Eğitimi
                    int aeD = Convert.ToInt32(txtAeD.Text);
                    int aeY = Convert.ToInt32(txtAeY.Text);
                    int aeB = Convert.ToInt32(txtAeB.Text);
                    double aeNet = aeD - 0.25 * aeY;
                    lblAeNet.Text = aeNet.ToString();

                    //Toplam
                    lblTopDog.Text = (aeD + cbD + astD + jeoD + bioD + kimyaD + fizikD).ToString(); //dogru
                    lblTopYanlıs.Text = (aeY + cbY + astY + jeoY + bioY + kimyaY + fizikY).ToString(); // yanlıs
                    lblTopBos.Text = (aeB + cbB + astB + jeoB + bioB + kimyaB + fizikB).ToString(); // bos
                    lblTopNet.Text = (aeNet + cbN + astN + jeoN + bioN + kimyaN + fizikN).ToString(); //net
                }
                catch
                {
                    MessageBox.Show(" EKsik Veya Hatalı Giriş Yaptınız", "SM Software", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblAeNet.Text = "";
            lblFizikNet.Text = "";
            lblBioNet.Text = "";
            lblKimyaNet.Text = "";
            lblCbNet.Text = "";
            lblJeoNet.Text = "";
            lblAstNet.Text = "";
            lblTopBos.Text = "";
            lblTopDog.Text = "";
            lblTopYanlıs.Text = "";
            lblTopNet.Text = "";
            textBox1.Text = "";



            foreach (Control c  in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        database db = new database();

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(db.adres);

            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("Insert Into TBL_oabtDeneme (tarih,Yayın,Süre,Fizik,Kimya,Biyoloji,Jeoloji,Astronomi,[Çevre Bilimi],[Alan Eğitimi],Toplam) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11)",baglanti);
            cmd3.Parameters.AddWithValue("@a1", textBox1.Text);
            cmd3.Parameters.AddWithValue("@a2", txtYayın.Text);
            cmd3.Parameters.AddWithValue("@a3", txtSure.Text);
            cmd3.Parameters.AddWithValue("@a4", lblFizikNet.Text);
            cmd3.Parameters.AddWithValue("@a5",lblKimyaNet.Text);
            cmd3.Parameters.AddWithValue("@a6", lblBioNet.Text);
            cmd3.Parameters.AddWithValue("@a7", lblJeoNet.Text);
            cmd3.Parameters.AddWithValue("@a8",lblAstNet.Text);
            cmd3.Parameters.AddWithValue("@a9",lblCbNet.Text);
            cmd3.Parameters.AddWithValue("@a10",lblAeNet.Text);
            cmd3.Parameters.AddWithValue("@a11", lblTopNet.Text);
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Netleriniz Başarılı Bir Şekilde Kayıt Edilmiştir", "SM Software", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }
    }
}
