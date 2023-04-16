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
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }

     

        private void frmyenimüsteri_Click(object sender, EventArgs e)
        {
            yenimüşteri fr = new yenimüşteri();
            fr.Show();

        }

        private void frmodalar_Click(object sender, EventArgs e)
        {

        }

        private void btnadmingiriş_Click(object sender, EventArgs e)
        {
            Frmodalar1 frmodalar1 = new Frmodalar1();   
            frmodalar1.Show();

        }
    }
}
