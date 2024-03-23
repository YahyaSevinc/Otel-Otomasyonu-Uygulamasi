using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle fm = new FrmMusteriEkle();
            fm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOdalar fo = new FrmOdalar();
            fo.Show();
            Visible = false;
        }
    }
}
