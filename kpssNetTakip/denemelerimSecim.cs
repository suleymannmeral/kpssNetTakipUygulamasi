using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kpssNetTakip
{
    public partial class denemelerimSecim : Form
    {
        public denemelerimSecim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            egitimBilimleriDetay frm = new egitimBilimleriDetay();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lisansDenemeGiris frm = new lisansDenemeGiris();
             frm.Show();
            this.Close();
        }

        private void denemelerimSecim_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            islemSecimForm frm = new islemSecimForm();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oabtDetay frm = new oabtDetay();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
