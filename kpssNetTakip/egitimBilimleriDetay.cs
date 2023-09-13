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
    public partial class egitimBilimleriDetay : Form
    {
        public egitimBilimleriDetay()
        {
            InitializeComponent();
        }
        database db = new database();

        private void tableview()
        {
            SqlConnection baglanti = new SqlConnection(db.adres);

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From TBL_egitimBilimleriDeneme Order BY id", baglanti);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }
        private void egitimBilimleriDetay_Load(object sender, EventArgs e)
        { 
             tableview();
            
            this.CenterToScreen();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            denemelerimSecim frm= new denemelerimSecim();
            frm.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtid.Text=="")
            {
                MessageBox.Show("ID Girişi Yapmadınız", "SM Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                SqlConnection baglanti = new SqlConnection(db.adres);

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Delete From TBL_egitimbilimleriDeneme where id=@k1", baglanti);
                cmd.Parameters.AddWithValue("@k1", txtid.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deneme verileriniz başarılı bir şekilde silinmiştir.", "SM Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tableview();
                txtid.Text = "";
                textBox2.Text = "";

            }
           



        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[choose].Cells[2].Value.ToString();

        }
    }
}
