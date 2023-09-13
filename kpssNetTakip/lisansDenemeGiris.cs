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
    public partial class lisansDenemeGiris : Form
    {
        public lisansDenemeGiris()
        {
            InitializeComponent();

        }
        database db = new database();


        private void lisansDenemeGiris_Load(object sender, EventArgs e)
        {
            tableview3();


            this.CenterToScreen();

        }
        private void tableview3()
        {
            SqlConnection baglanti = new SqlConnection(db.adres);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From TBL_lisansDeneme Order By Deneme_ID", baglanti);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }
        

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("ID Girişi Yapmadınız", "SM Software",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection baglanti = new SqlConnection(db.adres);
                baglanti.Open();
                SqlCommand cmd = new SqlCommand(" Delete From TBL_lisansDeneme where Deneme_ID=@p1", baglanti);
                cmd.Parameters.AddWithValue("@p1", txtID.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deneme verileriniz başarılı bir şekilde silinmiştir.", "SM Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDenemAd.Text = "";
                txtID.Text = "";
            }
            tableview3();


        }

        private void button2_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            txtDenemAd.Text= dataGridView1.Rows[choose].Cells[2].Value.ToString();
            
        }
    }
}
