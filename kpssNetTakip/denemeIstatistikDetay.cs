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
    public partial class denemeIstatistikDetay : Form
    {
        public denemeIstatistikDetay()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void denemeIstatistikDetay_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            islemSecimForm frm = new islemSecimForm();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lisansDenemeIst frm = new lisansDenemeIst();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEgitimBilimleriIstat frm= new frmEgitimBilimleriIstat();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oabtIstatistik frm = new oabtIstatistik();
            frm.Show();
            this.Hide();
        }
    }
}
