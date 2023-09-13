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
    public partial class denemeSecimEkranı : Form
    {
        public denemeSecimEkranı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lisansDeneme frm0 = new lisansDeneme();
            frm0.Show();
            this.Hide();
        }

        private void denemeSecimEkranı_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //lisans deneme ekranı 
            Form1 frm1 = new Form1();   
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            // EGİTM BİLM deneme ekranı
           
            egitimbimleri frm0 = new egitimbimleri();   
            frm0.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmOABT frm0 = new frmOABT();
            frm0.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            islemSecimForm frm0 = new islemSecimForm();
            frm0.Show();
            this.Hide();
        }
    }
}
