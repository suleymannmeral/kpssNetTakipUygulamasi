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
    public partial class islemSecimForm : Form
    {
        public islemSecimForm()
        {
            InitializeComponent();
        }

        private void islemSecimForm_Load(object sender, EventArgs e)
        {
            
            this.CenterToScreen(); 
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            denemeSecimEkranı frm1 = new denemeSecimEkranı();
            frm1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            denemelerimSecim frm1 = new denemelerimSecim();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            denemeIstatistikDetay frm = new denemeIstatistikDetay();
            frm.Show();
            this.Hide();
        }
    }
}
