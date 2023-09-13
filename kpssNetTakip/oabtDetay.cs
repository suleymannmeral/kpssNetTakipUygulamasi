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
    public partial class oabtDetay : Form
    {
        public oabtDetay()
        {
            InitializeComponent();
        }
            database db = new database();

        private void oabtDetay_Load(object sender, EventArgs e)
        {
            tableview2();
            this.CenterToScreen();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            tableview2();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            denemelerimSecim frm = new denemelerimSecim();
            frm.Show();
            this.Hide();
        }
        private void tableview2()
        {
            SqlConnection baglanti = new SqlConnection(db.adres);

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From TBL_oabtDeneme Order BY id", baglanti);
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ID Girişi Yapmadınız", "SM Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                SqlConnection baglanti = new SqlConnection(db.adres);

                baglanti.Open();
                SqlCommand cmd = new SqlCommand(" Delete From TBL_oabtDeneme where id=@p1", baglanti);
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deneme verileriniz başarılı bir şekilde silinmiştir.", "SM Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tableview2();
                textBox1.Text = "";
                textBox2.Text = "";
                
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[choose].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[choose].Cells[2].Value.ToString();

        }
    }
}
