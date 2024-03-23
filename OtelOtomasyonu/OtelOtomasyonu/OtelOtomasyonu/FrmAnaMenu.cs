using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OtelOtomasyonu
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            
           
        }

        private void kullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle fm = new FrmMusteriEkle();
            fm.Show();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciEkle fk = new FrmKullaniciEkle();
            fk.Show();
        }

        private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriListeleme fm = new FrmMusteriListeleme();
            fm.Show();
        }

        private void FrmAnaMenu_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
