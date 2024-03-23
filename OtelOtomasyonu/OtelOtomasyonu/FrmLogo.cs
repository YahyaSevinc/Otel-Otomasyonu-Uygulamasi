using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class FrmLogo : Form
    {
        int t1 = 0;
        public FrmLogo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            t1++;
            if (t1 == 2)
            {
                this.Opacity = 0.9;
            }
            else if (t1 == 3)
            {
                this.Opacity = 0.9;
            }
            else if (t1 == 4)
            {
                this.Opacity = 0.8;
            }
            else if (t1 == 5)
            {
                this.Opacity = 0.7;
            }
            else if (t1 == 6)
            {
                this.Opacity = 0.6;
            }
            else if (t1 == 7)
            {
                this.Opacity = 0.5;
            }
            else if (t1 == 8)
            {
                this.Opacity = 0.4;
            }
            else if (t1 == 9)
            {
                this.Opacity = 0.3;
            }
            else if (t1 == 10)
            {
                this.Opacity = 0.2;
            }
            else if (t1 == 11)
            {
                this.Opacity = 0.1;
            }
            else if (t1==12)
            {
                this.Opacity = 0.0;
                FrmAdminGiris fa = new FrmAdminGiris();
                fa.Show();
                Visible = false;
                timer1.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogo_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
