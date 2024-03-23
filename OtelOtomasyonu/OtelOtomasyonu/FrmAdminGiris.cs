using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace OtelOtomasyonu
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H3TH5TN\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
      //  SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == ""|| txtSifre.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from AdminGiris where KullaniciAdi='"+txtKullaniciAdi.Text+"'",baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read()==true)
                {
                    if (txtKullaniciAdi.Text == oku["KullaniciAdi"].ToString() && txtSifre.Text == oku["Sifre"].ToString())
                    {
                        MessageBox.Show("Hoşgeldiniz");
                        FrmAnaMenu fm = new FrmAnaMenu();
                        fm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bilgilerinizi Kontrol Ediniz");    
                    }
                }
                baglanti.Close();
            }

            //if (txtKullaniciAdi.Text == "admin"&&txtSifre.Text == "123")
            //{
            // FrmAnaMenu fm = new FrmAnaMenu();
            // fm.Show();
            // Visible = false;
            //}
            // else
            //           {
            //   MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            //   }
        }

        private void FrmAdminGiris_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_Click(object sender, EventArgs e)
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
           // Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
