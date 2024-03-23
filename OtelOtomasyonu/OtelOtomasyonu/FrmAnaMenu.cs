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
using System.Data.SqlClient;

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
            DialogResult result1 = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?", "Confractus Hotel", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
            
        }

        private void oda101ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOda101 fo = new FormOda101();
            fo.Show();
        }

        private void oda102ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form102 fo2 = new Form102();
            fo2.Show();
        }

        private void oda103ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOda103 fo = new FrmOda103();
            fo.Show();

        }

        private void oda104ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOda104 fo = new FrmOda104();
            fo.Show();
        }

        private void oda105ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOda105 fo = new FrmOda105();
            fo.Show();
        }

        private void oda106ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOda106 fo = new FrmOda106();
            fo.Show();
        }

        private void oda107ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOda107 fo = new FrmOda107();
            fo.Show();
        }

        private void oda108ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOda108 fo = new FrmOda108();
            fo.Show();
        }

        private void oda109ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOda109 fo = new FrmOda109();
            fo.Show();
        }

        private void kullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciListeleme fm = new FrmKullaniciListeleme();
            fm.Show();
        }

        private void süresiDolanllarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuresiDolanlar fs = new FrmSuresiDolanlar();
            fs.Show();
        }

        private void gelirGiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void oda201ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOda201 f2 = new FrmOda201();
            f2.Show();
        }

        private void oda202ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOda202 f22 = new FrmOda202();
            f22.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
