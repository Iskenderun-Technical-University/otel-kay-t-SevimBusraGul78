using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class yenimüşteri : Form
    {
        public yenimüşteri()
        {
            InitializeComponent();
        }

        private void btnoda101_Click(object sender, EventArgs e)
        {
            txtoda.Text = "101";
        }

        private void btnoda102_Click(object sender, EventArgs e)
        {
            txtoda.Text = "102";
        }

        private void btnoda103_Click(object sender, EventArgs e)
        {
            txtoda.Text = "103";
        }

        private void btnoda104_Click(object sender, EventArgs e)
        {
            txtoda.Text = "104";
        }

        private void btnoda105_Click(object sender, EventArgs e)
        {
            txtoda.Text = "105";
        }

        private void btnoda106_Click(object sender, EventArgs e)
        {
            txtoda.Text = "106";
        }

        private void btnoda107_Click(object sender, EventArgs e)
        {
            txtoda.Text = "107";
        }

        private void btnoda108_Click(object sender, EventArgs e)
        {
            txtoda.Text = "108";
        }

        private void btnoda109_Click(object sender, EventArgs e)
        {
            txtoda.Text = "109";
        }

        private void btndoluoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kırmızı renkli odalar dolu olduğunu gösterir");
        }

        private void btnboşoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gri renkli odalar boş olduğunu gösterir");
        }

        private void dtpçıkış_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih=Convert.ToDateTime(dtpgiriş.Text);
            DateTime buyuktarih=Convert.ToDateTime(dtpçıkış.Text);

            TimeSpan sonuc=buyuktarih-kucukTarih;

            label10.Text = sonuc.TotalDays.ToString();    
            ucret=Convert.ToInt32(label10.Text)*50;
            richTextBox1.Text = ucret.ToString();   

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbcinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void msktxttel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
