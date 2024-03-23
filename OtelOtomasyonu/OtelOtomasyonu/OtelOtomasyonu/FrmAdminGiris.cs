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

namespace OtelOtomasyonu
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=SEVINC24\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
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
    }
}
